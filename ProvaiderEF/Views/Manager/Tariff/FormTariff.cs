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
    public partial class FormTariff : FormAbstractClass
    {
        public MyContext dbContext { get; private set; }
        private TariffDataFilter tariffDataFilter;
        public FormTariff()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(34, 33, 74);

            dbContext = new MyContext();
            RefreshTable(dataGridViewTariff, dbContext.Tariffs);

            tariffDataFilter = new TariffDataFilter(dbContext.Tariffs);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tariffDataFilter.FilterDataGridView(dataGridViewTariff, textBoxSearch.Text.ToLower());
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {           
            tariffDataFilter.FilterDataGridView(dataGridViewTariff, textBoxSearch.Text.ToLower());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormNewTariff formNewTariff = new FormNewTariff();
            DialogResult = formNewTariff.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;

            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    Tariff tariff = new Tariff();
                    tariff.TariffName = formNewTariff.textBoxName.Text;
                    tariff.TariffCost = Convert.ToDecimal(formNewTariff.textBoxCost.Text);
                    tariff.Speed = Convert.ToInt32(formNewTariff.textBoxSpeed.Text);
                    tariff.TariffDescription = formNewTariff.textBoxDesc.Text;
                    tariff.PaymentType = formNewTariff.comboBoxType.SelectedItem != null
                        ? formNewTariff.comboBoxType.SelectedItem.ToString()
                        : "На месяц";

                    dbContext.Add(tariff);
                    dbContext.SaveChanges();

                    transaction.Commit(); 

                    RefreshTable(dataGridViewTariff, dbContext.Tariffs);
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

            if (dataGridViewTariff.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewTariff.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewTariff.SelectedRows[0];
                int tariffId = Convert.ToInt32(selectedRow.Cells[0].Value);
                Tariff? tariffToUpdate = dbContext.Tariffs.Find(tariffId);

                if (tariffToUpdate != null)
                {
                    FormNewTariff formNewTariff = new FormNewTariff();

                    formNewTariff.textBoxName.TextValue = tariffToUpdate.TariffName;
                    formNewTariff.textBoxDesc.TextValue = tariffToUpdate.TariffDescription;
                    formNewTariff.textBoxCost.TextValue = tariffToUpdate.TariffCost.ToString();
                    formNewTariff.textBoxSpeed.TextValue = tariffToUpdate.Speed.ToString();
                    if (formNewTariff.comboBoxType.Items.Contains(tariffToUpdate.PaymentType.ToString()))
                    {
                        
                        formNewTariff.comboBoxType.SelectedItem = tariffToUpdate.PaymentType.ToString();
                    }
                    else
                    {
                        formNewTariff.comboBoxType.SelectedIndex = 0;
                    }

                    DialogResult = formNewTariff.ShowDialog(this);
                    if (DialogResult == DialogResult.Cancel) return;

                    using (var transaction = dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            tariffToUpdate.TariffName = formNewTariff.textBoxName.Text;
                            tariffToUpdate.TariffCost = Convert.ToDecimal(formNewTariff.textBoxCost.Text);
                            tariffToUpdate.Speed = Convert.ToInt32(formNewTariff.textBoxSpeed.Text);
                            tariffToUpdate.TariffDescription = formNewTariff.textBoxDesc.Text;
                            tariffToUpdate.PaymentType = formNewTariff.comboBoxType.SelectedItem != null
                                ? formNewTariff.comboBoxType.SelectedItem.ToString()
                                : "На месяц";

                            dbContext.SaveChanges(); 
                            transaction.Commit(); 

                            RefreshTable(dataGridViewTariff, dbContext.Tariffs);
                            dataGridViewTariff.ClearSelection();
                            dataGridViewTariff.Rows[selectedIndex].Selected = true;
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
                    MessageBox.Show("Выбранный тариф не найден");
                }
            }
            else if (dataGridViewTariff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Тариф не выбран");
            }
            else if (dataGridViewTariff.SelectedRows.Count > 1)
            {
                MessageBox.Show("Изменить сразу несколько тарифов нельзя");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTariff.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewTariff.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewTariff.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Tariff? tariff = dbContext.Tariffs.Find(id);

                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Tariffs.Remove(tariff);
                        dbContext.SaveChanges();
                        transaction.Commit();

                        RefreshTable(dataGridViewTariff, dbContext.Tariffs);
                        dataGridViewTariff.ClearSelection();
                        dataGridViewTariff.Rows[selectedIndex - 1].Selected = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                        transaction.Rollback();
                    }
                }
            }
            else if (dataGridViewTariff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Тариф не выбран");
            }
            else if (dataGridViewTariff.SelectedRows.Count > 1)
            {
                MessageBox.Show("Удалить сразу несколько тарифов нельзя");
            }
        }
    }
}
