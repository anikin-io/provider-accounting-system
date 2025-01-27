using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaiderEF
{
    public partial class FormEquipment : FormAbstractClass
    {
        public MyContext dbContext { get; private set; }
        private List<object> originalData = new List<object>();
        private Dictionary<string, string> columnHeaders = new Dictionary<string, string>();
        private Dictionary<string, DataGridViewAutoSizeColumnMode> columnAutoSizeMode = new Dictionary<string, DataGridViewAutoSizeColumnMode>();

        public FormEquipment()
        {
            InitializeComponent();
            dbContext = new MyContext();

            this.BackColor = Color.FromArgb(34, 33, 74);
        }

        private Dictionary<string, string> columnMappings = new Dictionary<string, string>
        {
            { "ID", "EquipmentId" },
            { "Модель", "Model" },
            {"Стоимость продажи","SellingCost" }
        };

        private void FormEquipment_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            var combinedData = dbContext.Equipments
                   .Select(equipment => new
                   {
                       EquipmentId = equipment.EquipmentId,
                       Model = equipment.Model,
                       SellingCost = equipment.SellingCost
                   })
                   .ToList();

            List<object> dataList = new List<object>();
            foreach (var item in combinedData)
            {
                dataList.Add(new
                {
                    EquipmentId = item.EquipmentId,
                    Model = item.Model,
                    SellingCost = item.SellingCost,
                });
            }

            dataGridViewEquipment.DataSource = dataList;

            dataGridViewEquipment.Columns["EquipmentId"].HeaderText = "ID";
            dataGridViewEquipment.Columns["Model"].HeaderText = "Модель";
            dataGridViewEquipment.Columns["SellingCost"].HeaderText = "Стоимость продажи";

            dataGridViewEquipment.Columns["EquipmentId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewEquipment.Columns["Model"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewEquipment.Columns["SellingCost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            originalData = dataList.ToList();

            SaveDataGridViewSettings();
        }

        private void SaveDataGridViewSettings()
        {
            columnHeaders.Clear();
            columnAutoSizeMode.Clear();

            foreach (DataGridViewColumn column in dataGridViewEquipment.Columns)
            {
                columnHeaders[column.Name] = column.HeaderText;
                columnAutoSizeMode[column.Name] = column.AutoSizeMode;
            }
        }

        private void RestoreDataGridViewSettings()
        {
            foreach (var kvp in columnHeaders)
            {
                if (dataGridViewEquipment.Columns.Contains(kvp.Key))
                {
                    dataGridViewEquipment.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }

            foreach (var kvp in columnAutoSizeMode)
            {
                if (dataGridViewEquipment.Columns.Contains(kvp.Key))
                {
                    dataGridViewEquipment.Columns[kvp.Key].AutoSizeMode = kvp.Value;
                }
            }
        }

        private void ApplyFilterAndUpdateDataGridView(string searchTerm)
        {
            var filteredData = originalData;

            filteredData = originalData.Where(item =>
                columnMappings.Any(mapping =>
                    item.GetType().GetProperty(mapping.Value)?.GetValue(item)?.ToString().ToLower().Contains(searchTerm) ?? false))
                .ToList();

            dataGridViewEquipment.DataSource = filteredData.Count == 0 ? filteredData.Take(0).ToList() : filteredData;

            RestoreDataGridViewSettings();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.ToLower();
            ApplyFilterAndUpdateDataGridView(searchTerm);
        }
        private void TextBoxSearch__TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.ToLower();
            ApplyFilterAndUpdateDataGridView(searchTerm);
        }

        private void dataGridViewEquipment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewEquipment.Columns[e.ColumnIndex].Name == "Model")
            {
                e.CellStyle.ForeColor = Color.MediumAquamarine;
            }

            if (e.RowIndex >= 0 &&
                    (dataGridViewEquipment.Columns[e.ColumnIndex].Name == "SellingCost") &&
                    e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    string formattedValue = value.ToString("#.##") + " ₽"; 
                    e.Value = formattedValue;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormNewEquipment formNewEquipment = new FormNewEquipment();
            DialogResult = formNewEquipment.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;

            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(formNewEquipment.textBoxSellingCost.Text) &&
                        !string.IsNullOrWhiteSpace(formNewEquipment.textBoxModel.Text))
                    {
                        Equipment equipment = new Equipment();
                        equipment.Model = string.IsNullOrWhiteSpace(formNewEquipment.textBoxModel.Text) ? null : formNewEquipment.textBoxModel.Text;
                        equipment.SellingCost = Convert.ToDecimal(formNewEquipment.textBoxSellingCost.Text);

                        dbContext.Add(equipment);
                        dbContext.SaveChanges(); 

                        transaction.Commit(); 

                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: необходимо заполнить все обязательные поля.");
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Ошибка: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewEquipment.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewEquipment.SelectedRows[0];
                int Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Equipment equipmentToUpdate = dbContext.Equipments.FirstOrDefault(e => e.EquipmentId == Id);

                if (equipmentToUpdate != null)
                {
                    FormNewEquipment formNewEquipment = new FormNewEquipment();

                    formNewEquipment.textBoxModel.TextValue = equipmentToUpdate.Model;
                    formNewEquipment.textBoxSellingCost.TextValue = equipmentToUpdate.SellingCost.ToString();

                    DialogResult = formNewEquipment.ShowDialog(this);
                    if (DialogResult == DialogResult.Cancel) return;

                    using (var transaction = dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            if (!string.IsNullOrWhiteSpace(formNewEquipment.textBoxSellingCost.Text) &&                               
                                !string.IsNullOrWhiteSpace(formNewEquipment.textBoxModel.Text))
                            {
                                equipmentToUpdate.Model = formNewEquipment.textBoxModel.Text;
                                equipmentToUpdate.SellingCost = Convert.ToDecimal(formNewEquipment.textBoxSellingCost.Text);

                                dbContext.SaveChanges(); 
                                transaction.Commit();

                                LoadDataToDataGridView();
                                dataGridViewEquipment.ClearSelection();
                                dataGridViewEquipment.Rows[selectedIndex].Selected = true;
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: необходимо заполнить все обязательные поля.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                            transaction.Rollback(); 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбранное оборудование не найдено");
                }
            }
            else if (dataGridViewEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оборудование не выбрано");
            }
            else if (dataGridViewEquipment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Изменить сразу несколько штук нельзя");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewEquipment.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewEquipment.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Equipment? equipment = dbContext.Equipments.FirstOrDefault(e => e.EquipmentId == id);

                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Equipments.Remove(equipment);
                        dbContext.SaveChanges();
                        transaction.Commit();

                        LoadDataToDataGridView();
                        dataGridViewEquipment.ClearSelection();
                        dataGridViewEquipment.Rows[selectedIndex - 1].Selected = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            else if (dataGridViewEquipment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оборудование не выбрано");
            }
            else if (dataGridViewEquipment.SelectedRows.Count > 1)
            {
                MessageBox.Show("Удалить сразу несколько штук нельзя");
            }
        }
    }
}
