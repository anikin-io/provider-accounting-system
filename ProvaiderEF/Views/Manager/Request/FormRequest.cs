using Azure.Core;
using GMap.NET.MapProviders;
using Microsoft.EntityFrameworkCore;
using ProvaiderEF.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProvaiderEF
{
    public partial class FormRequest : FormAbstractClass
    {
        public MyContext dbContext { get; private set; }

        private List<object> originalData = new List<object>();
        private Dictionary<string, string> columnHeaders = new Dictionary<string, string>();
        private Dictionary<string, DataGridViewAutoSizeColumnMode> columnAutoSizeMode = new Dictionary<string, DataGridViewAutoSizeColumnMode>();

        public FormRequest()
        {
            InitializeComponent();
            dbContext = new MyContext();

            this.BackColor = Color.FromArgb(34, 33, 74);

            InitializeComboBox();
        }

        private Dictionary<string, string> columnMappings = new Dictionary<string, string>
        {
            { "Фамилия", "LastName" },
            { "Имя", "FirstName" },
            { "Отчество", "MiddleName" },
            { "Телефон", "PhoneNumber" },
            { "Адрес", "Address" },
            { "Тариф", "TariffName" },
            { "Оборудование", "Model" },
            { "Дата заявки", "RequestDate" },
            { "Описание", "RequestDescription" },
            { "Статус", "RequestStatus" }
        };
        private void InitializeComboBox()
        {
            comboBoxFilter.Items.Add("По всем");
            comboBoxFilter.Items.AddRange(columnMappings.Keys.ToArray());
            comboBoxFilter.SelectedIndex = 0;
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            var combinedData = dbContext.Requests
            .Select(request => new
            {
                LastName = request.PotentialSubscriber != null ? request.PotentialSubscriber.LastName : "",
                FirstName = request.PotentialSubscriber != null ? request.PotentialSubscriber.FirstName : "",
                MiddleName = request.PotentialSubscriber != null ? request.PotentialSubscriber.MiddleName : "—",
                PhoneNumber = request.PotentialSubscriber != null ? request.PotentialSubscriber.PhoneNumber : "",
                Address = request.PotentialSubscriber != null ? request.PotentialSubscriber.Address : "",
                TariffName = request.Tariff != null ? request.Tariff.TariffName : "",
                Model = request.Equipment != null ? request.Equipment.Model : "—",
                RequestId = request.RequestId,
                RequestDate = request.RequestDate,
                RequestDescription = !string.IsNullOrWhiteSpace(request.RequestDescription) ? request.RequestDescription : "—",
                RequestStatus = request.RequestStatus
            })
            .ToList();

            List<object> dataList = new List<object>();
            foreach (var item in combinedData)
            {
                dataList.Add(new
                {
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    PhoneNumber = item.PhoneNumber,
                    Address = item.Address,
                    TariffName = item.TariffName,
                    Model = item.Model,
                    RequestId = item.RequestId,
                    RequestDate = item.RequestDate,
                    RequestDescription = item.RequestDescription,
                    RequestStatus = item.RequestStatus
                });
            }

            dataGridViewRequest.DataSource = dataList;

            dataGridViewRequest.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewRequest.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewRequest.Columns["MiddleName"].HeaderText = "Отчество";
            dataGridViewRequest.Columns["PhoneNumber"].HeaderText = "Телефон";
            dataGridViewRequest.Columns["Address"].HeaderText = "Адрес";
            dataGridViewRequest.Columns["TariffName"].HeaderText = "Тариф";
            dataGridViewRequest.Columns["Model"].HeaderText = "Оборудование";
            dataGridViewRequest.Columns["RequestDate"].HeaderText = "Дата заявки";
            dataGridViewRequest.Columns["RequestDescription"].HeaderText = "Описание";
            dataGridViewRequest.Columns["RequestStatus"].HeaderText = "Статус";

            dataGridViewRequest.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["MiddleName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["TariffName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["RequestDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["RequestStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewRequest.Columns["RequestId"].HeaderText = "RequestId";
            dataGridViewRequest.Columns["RequestId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["RequestId"].Visible = false;

            originalData = dataList.ToList();

            SaveDataGridViewSettings();
        }

        private void dataGridViewRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewRequest.Columns[e.ColumnIndex].Name == "FirstName" ||
                dataGridViewRequest.Columns[e.ColumnIndex].Name == "MiddleName" ||
                dataGridViewRequest.Columns[e.ColumnIndex].Name == "LastName")
            {
                e.CellStyle.ForeColor = Color.MediumAquamarine;
            }

            if (dataGridViewRequest.Columns[e.ColumnIndex].Name == "RequestDate" && e.Value != null && e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("dd.MM.yyyy");
                e.FormattingApplied = true;
            }

            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string searchTerm = textBoxSearch.Text.ToLower();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Value != null && !string.IsNullOrEmpty(searchTerm))
            {
                string cellText = e.Value.ToString().ToLower();

                if (selectedColumn == "По всем")
                {
                    if (cellText.Contains(searchTerm))
                    {
                        e.CellStyle.ForeColor = Color.Red;

                        if (dataGridViewRequest.Rows[e.RowIndex].Selected)
                        {
                            e.CellStyle.SelectionForeColor = Color.Red;
                            e.CellStyle.SelectionBackColor = dataGridViewRequest.DefaultCellStyle.SelectionBackColor;
                        }
                    }
                }
            }
        }

        private void ApplyFilterAndUpdateDataGridView(string searchTerm, string selectedColumn)
        {
            var filteredData = originalData;

            if (selectedColumn != "По всем")
            {
                filteredData = originalData.Where(item =>
                    item.GetType().GetProperty(columnMappings[selectedColumn])?.GetValue(item)?.ToString().ToLower().Contains(searchTerm) ?? false)
                    .ToList();
            }
            else
            {
                filteredData = originalData.Where(item =>
                    columnMappings.Any(mapping =>
                        item.GetType().GetProperty(mapping.Value)?.GetValue(item)?.ToString().ToLower().Contains(searchTerm) ?? false))
                    .ToList();
            }

            dataGridViewRequest.DataSource = filteredData.Count == 0 ? filteredData.Take(0).ToList() : filteredData;

            RestoreDataGridViewSettings();

            if (dataGridViewRequest.Columns["RequestId"] != null)
            {
                dataGridViewRequest.Columns["RequestId"].Visible = false;
            }
        }

        private void SaveDataGridViewSettings()
        {
            columnHeaders.Clear();
            columnAutoSizeMode.Clear();

            foreach (DataGridViewColumn column in dataGridViewRequest.Columns)
            {
                columnHeaders[column.Name] = column.HeaderText;
                columnAutoSizeMode[column.Name] = column.AutoSizeMode;
            }
        }

        private void RestoreDataGridViewSettings()
        {
            foreach (var kvp in columnHeaders)
            {
                if (dataGridViewRequest.Columns.Contains(kvp.Key))
                {
                    dataGridViewRequest.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }

            foreach (var kvp in columnAutoSizeMode)
            {
                if (dataGridViewRequest.Columns.Contains(kvp.Key))
                {
                    dataGridViewRequest.Columns[kvp.Key].AutoSizeMode = kvp.Value;
                }
            }
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string searchTerm = textBoxSearch.Text.ToLower();
            ApplyFilterAndUpdateDataGridView(searchTerm, selectedColumn);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string searchTerm = textBoxSearch.Text.ToLower();
            ApplyFilterAndUpdateDataGridView(searchTerm, selectedColumn);
        }

        private void comboBoxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string searchTerm = textBoxSearch.Text.ToLower();
            ApplyFilterAndUpdateDataGridView(searchTerm, selectedColumn);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormNewRequest formNewRequest = new FormNewRequest();
            LoadTariffsIntoComboBox(formNewRequest);
            LoadEquipmentsIntoComboBox(formNewRequest);
            LoadStatusesIntoComboBox(formNewRequest);
            DialogResult = formNewRequest.ShowDialog(this);
            if (DialogResult == DialogResult.Cancel) return;

            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    PotentialSubscriber potentialSubscriber = new PotentialSubscriber
                    {
                        FirstName = string.IsNullOrWhiteSpace(formNewRequest.textBoxFirstName.Text) ? null : formNewRequest.textBoxFirstName.Text,
                        MiddleName = string.IsNullOrWhiteSpace(formNewRequest.textBoxMiddleName.Text) ? null : formNewRequest.textBoxMiddleName.Text,
                        LastName = string.IsNullOrWhiteSpace(formNewRequest.textBoxLastName.Text) ? null : formNewRequest.textBoxLastName.Text,
                        PhoneNumber = string.IsNullOrWhiteSpace(formNewRequest.textBoxPhone.Text) ? null : formNewRequest.textBoxPhone.Text,
                        Address = string.IsNullOrWhiteSpace(formNewRequest.textBoxAdress.Text) ? null : formNewRequest.textBoxAdress.Text
                    };

                    dbContext.PotentialSubscribers.Add(potentialSubscriber);
                    dbContext.SaveChanges(); 

                    int newSubscriberId = potentialSubscriber.PotentialSubscriberId;

                    DateTime selectedDate = formNewRequest.datePickerRequest.Value.Date;
                    DateTime selectedTime = formNewRequest.timePickerRequest.Value;


                    DateTime combinedDateTime = new DateTime(
                        selectedDate.Year,
                        selectedDate.Month,
                        selectedDate.Day,
                        selectedTime.Hour,
                        selectedTime.Minute,
                        selectedTime.Second);


                    Request request = new Request
                    {
                        PotentialSubscriberId = newSubscriberId,
                        TariffId = (int)formNewRequest.comboBoxTariff.SelectedValue, 
                        EquipmentId = formNewRequest.checkBoxEquipment.Enabled ? (int?)formNewRequest.comboBoxEquipment.SelectedValue : null, 
                        RequestDate = combinedDateTime,
                        RequestDescription = string.IsNullOrWhiteSpace(formNewRequest.textBoxDesc.Text) ? null : formNewRequest.textBoxDesc.Text,
                        RequestStatus = formNewRequest.comboBoxStatus.SelectedItem != null ? formNewRequest.comboBoxStatus.SelectedItem.ToString() : "Создана"
                    };


                    dbContext.Requests.Add(request);
                    dbContext.SaveChanges();

                    transaction.Commit();

                    LoadDataToDataGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка: " + ex.Message);
                    transaction.Rollback(); 
                }
            }
        }
        private void LoadTariffsIntoComboBox(FormNewRequest formNewRequest)
        {
            var tariffs = dbContext.Tariffs.ToList();

            formNewRequest.comboBoxTariff.DisplayMember = "TariffName";
            formNewRequest.comboBoxTariff.ValueMember = "TariffId";
            formNewRequest.comboBoxTariff.DataSource = tariffs;
        }
        private void LoadEquipmentsIntoComboBox(FormNewRequest formNewRequest)
        {
            var equipments = dbContext.Equipments.ToList();

            formNewRequest.comboBoxEquipment.DisplayMember = "Model";
            formNewRequest.comboBoxEquipment.ValueMember = "EquipmentId";
            formNewRequest.comboBoxEquipment.DataSource = equipments;
        }
        private void LoadStatusesIntoComboBox(FormNewRequest formNewRequest)
        {
            string[] statuses = { "Создана", "Отменена", "Выполнена" };

            formNewRequest.comboBoxStatus.Items.AddRange(statuses);

            formNewRequest.comboBoxStatus.SelectedItem = "Создана";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewRequest.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewRequest.SelectedRows[0];
                int requestId = Convert.ToInt32(selectedRow.Cells["RequestId"].Value);
                Request requestToUpdate = dbContext.Requests.Find(requestId);

                if (requestToUpdate != null)
                {
                    FormNewRequest formNewRequest = new FormNewRequest();

                    var subscriberData = dbContext.PotentialSubscribers.FirstOrDefault(p => p.PotentialSubscriberId == requestToUpdate.PotentialSubscriberId);

                    formNewRequest.textBoxFirstName.Text = subscriberData?.FirstName;
                    formNewRequest.textBoxMiddleName.Text = subscriberData?.MiddleName;
                    formNewRequest.textBoxLastName.Text = subscriberData?.LastName;
                    formNewRequest.textBoxPhone.Text = subscriberData?.PhoneNumber;
                    formNewRequest.textBoxAdress.Text = subscriberData?.Address;

                    var tariffs = dbContext.Tariffs.ToList();
                    formNewRequest.comboBoxTariff.DisplayMember = "TariffName";
                    formNewRequest.comboBoxTariff.ValueMember = "TariffId";
                    formNewRequest.comboBoxTariff.DataSource = tariffs;
                    var selectedTariffIndex = tariffs.FindIndex(t => t.TariffId == requestToUpdate.TariffId);
        
                    if (selectedTariffIndex >= 0)
                    {
                        formNewRequest.comboBoxTariff.SelectedIndex = selectedTariffIndex;
                    }
                    else
                    {
                        
                        formNewRequest.comboBoxTariff.SelectedIndex = 0;
                    }

                    var equipmentList = dbContext.Equipments.ToList();
                    formNewRequest.comboBoxEquipment.DisplayMember = "Model";
                    formNewRequest.comboBoxEquipment.ValueMember = "EquipmentId";
                    formNewRequest.comboBoxEquipment.DataSource = equipmentList;
                    var selectedEquipmentIndex = equipmentList.FindIndex(e => e.EquipmentId == requestToUpdate.EquipmentId);
                    if (selectedEquipmentIndex >= 0)
                    {
                        formNewRequest.comboBoxEquipment.SelectedIndex = selectedEquipmentIndex;
                        formNewRequest.checkBoxEquipment.Checked = false;
                    }
                    else
                    {
                        formNewRequest.comboBoxEquipment.SelectedIndex = 0;
                        formNewRequest.checkBoxEquipment.Checked = true;
                    }


                    formNewRequest.datePickerRequest.Value = requestToUpdate.RequestDate.Date;
                    formNewRequest.timePickerRequest.Value = requestToUpdate.RequestDate;

                    formNewRequest.textBoxDesc.Text = requestToUpdate.RequestDescription;

                    string[] statuses = { "Создана", "Отменена", "Выполнена" };
                    formNewRequest.comboBoxStatus.Items.AddRange(statuses);
                    if (!string.IsNullOrEmpty(requestToUpdate.RequestStatus) && statuses.Contains(requestToUpdate.RequestStatus))
                    {
                        formNewRequest.comboBoxStatus.SelectedItem = requestToUpdate.RequestStatus;
                    }
                    else
                    {
                        formNewRequest.comboBoxStatus.SelectedIndex = 0; 
                    }

                    DialogResult = formNewRequest.ShowDialog(this);
                    if (DialogResult == DialogResult.Cancel) return;

                    using (var transaction = dbContext.Database.BeginTransaction())
                    {
                        try
                        {

                            requestToUpdate.PotentialSubscriber.FirstName = string.IsNullOrWhiteSpace(formNewRequest.textBoxFirstName.Text) ? null : formNewRequest.textBoxFirstName.Text;
                            requestToUpdate.PotentialSubscriber.MiddleName = string.IsNullOrWhiteSpace(formNewRequest.textBoxMiddleName.Text) ? null : formNewRequest.textBoxMiddleName.Text;
                            requestToUpdate.PotentialSubscriber.LastName = string.IsNullOrWhiteSpace(formNewRequest.textBoxLastName.Text) ? null : formNewRequest.textBoxLastName.Text;
                            requestToUpdate.PotentialSubscriber.PhoneNumber = string.IsNullOrWhiteSpace(formNewRequest.textBoxPhone.Text) ? null : formNewRequest.textBoxPhone.Text;
                            requestToUpdate.PotentialSubscriber.Address = string.IsNullOrWhiteSpace(formNewRequest.textBoxAdress.Text) ? null : formNewRequest.textBoxAdress.Text;
                            requestToUpdate.TariffId = (int)formNewRequest.comboBoxTariff.SelectedValue;
                            requestToUpdate.EquipmentId = formNewRequest.checkBoxEquipment.Checked ? null : (int?)formNewRequest.comboBoxEquipment.SelectedValue;
                            requestToUpdate.RequestDescription = string.IsNullOrWhiteSpace(formNewRequest.textBoxDesc.Text) ? null : formNewRequest.textBoxDesc.Text;
                            requestToUpdate.RequestStatus = formNewRequest.comboBoxStatus.SelectedItem != null ? formNewRequest.comboBoxStatus.SelectedItem.ToString() : "Создана";

                            DateTime selectedDate = formNewRequest.datePickerRequest.Value.Date;
                            DateTime selectedTime = formNewRequest.timePickerRequest.Value;
                            DateTime combinedDateTime = new DateTime(
                                selectedDate.Year,
                                selectedDate.Month,
                                selectedDate.Day,
                                selectedTime.Hour,
                                selectedTime.Minute,
                                selectedTime.Second);
                            requestToUpdate.RequestDate = combinedDateTime;

                            dbContext.SaveChanges();
                            transaction.Commit(); 

                            LoadDataToDataGridView();
                            dataGridViewRequest.ClearSelection();
                            dataGridViewRequest.Rows[selectedIndex].Selected = true;
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
                    MessageBox.Show("Выбранная заявка не найдена");
                }
            }
            else if (dataGridViewRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Заявка не выбрана");
            }
            else if (dataGridViewRequest.SelectedRows.Count > 1)
            {
                MessageBox.Show("Изменить сразу несколько заявок нельзя");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewRequest.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewRequest.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["RequestId"].Value);
                Request? request = dbContext.Requests.Find(id);
                var subscriber = dbContext.PotentialSubscribers.FirstOrDefault(p => p.PotentialSubscriberId == request.PotentialSubscriberId);

                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.PotentialSubscribers.Remove(subscriber);
                        dbContext.SaveChanges();
                        transaction.Commit();

                        LoadDataToDataGridView();
                        dataGridViewRequest.ClearSelection();
                        dataGridViewRequest.Rows[selectedIndex - 1].Selected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                        transaction.Rollback(); 
                    }
                }
            }
            else if (dataGridViewRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Заявка не выбрана");
            }
            else if (dataGridViewRequest.SelectedRows.Count > 1)
            {
                MessageBox.Show("Удалить сразу несколько заявок нельзя");
            }
        }
    }
}
