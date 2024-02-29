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

namespace ProvaiderEF
{
    public partial class FormRequestMaster : FormAbstractClass
    {
        public MyContext dbContext { get; private set; }

        private List<object> originalData = new List<object>();
        private Dictionary<string, string> columnHeaders = new Dictionary<string, string>();
        private Dictionary<string, DataGridViewAutoSizeColumnMode> columnAutoSizeMode = new Dictionary<string, DataGridViewAutoSizeColumnMode>();

        private int employeeId;
        public FormRequestMaster(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            dbContext = new MyContext();
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

        private void FormRequestMaster_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            var combinedData = dbContext.Requests
            .Where(request => request.RequestStatus == "Создана" || request.RequestStatus == "Выполнена") // Добавляем фильтр по статусу заявки
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

            // Создаем список объектов и заполняем его элементами анонимного типа
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

            // Назначить combinedData как источник данных для DataGridView
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

            // Сохраняем исходные данные перед изменением
            originalData = dataList.ToList();

            SaveDataGridViewSettings();

            dataGridViewRequest.Columns["RequestId"].HeaderText = "RequestId";
            dataGridViewRequest.Columns["RequestId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRequest.Columns["RequestId"].Visible = false;
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
                //if (selectedColumn == "По всем" || dataGridViewRequest.Columns[e.ColumnIndex].HeaderText == selectedColumn)
                {
                    if (cellText.Contains(searchTerm))
                    {
                        e.CellStyle.ForeColor = Color.Red;

                        // Применить стиль для выделенной ячейки, чтобы подсветить текст
                        if (dataGridViewRequest.Rows[e.RowIndex].Selected)
                        {
                            e.CellStyle.SelectionForeColor = Color.Red;
                            e.CellStyle.SelectionBackColor = dataGridViewRequest.DefaultCellStyle.SelectionBackColor; // сохранение стандартного цвета фона
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            LoadFinishRequest();

        }

        private void LoadFinishRequest()
        {
            if (dataGridViewRequest.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewRequest.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridViewRequest.SelectedRows[0];
                int requestId = Convert.ToInt32(selectedRow.Cells["RequestId"].Value);
                Request requestToFinish = dbContext.Requests.Find(requestId);

                if (requestToFinish.RequestStatus != "Выполнена")
                {
                    FormFinishRequest formFinishRequest = new FormFinishRequest();

                    var subscriberData = dbContext.PotentialSubscribers.FirstOrDefault(p => p.PotentialSubscriberId == requestToFinish.PotentialSubscriberId);

                    // Устанавливаем значения из базы данных в элементы формы
                    formFinishRequest.textBoxFirstName.Text = subscriberData.FirstName;
                    formFinishRequest.textBoxMiddleName.Text = subscriberData?.MiddleName;
                    formFinishRequest.textBoxLastName.Text = subscriberData.LastName;
                    formFinishRequest.textBoxPhone.Text = subscriberData.PhoneNumber;
                    formFinishRequest.textBoxAdress.Text = subscriberData.Address;

                    var tariffs = dbContext.Tariffs.ToList();
                    formFinishRequest.comboBoxTariff.DisplayMember = "TariffName";
                    formFinishRequest.comboBoxTariff.ValueMember = "TariffId";
                    formFinishRequest.comboBoxTariff.DataSource = tariffs;
                    // Поиск индекса тарифа, который соответствует выбранному тарифу
                    var selectedTariffIndex = tariffs.FindIndex(t => t.TariffId == requestToFinish.TariffId);
                    // Установка выбранного индекса в комбо-боксе тарифов
                    if (selectedTariffIndex >= 0)
                    {
                        formFinishRequest.comboBoxTariff.SelectedIndex = selectedTariffIndex;
                    }
                    else
                    {
                        // Если индекс не найден, выбераем первый элемент в комбо-боксе
                        formFinishRequest.comboBoxTariff.SelectedIndex = 0;
                    }
                    formFinishRequest.textBoxLogin.Text = RandomCredentialsGenerator.GenerateRandomLogin();
                    formFinishRequest.textBoxPassword.Text = RandomCredentialsGenerator.GenerateRandomPassword();

                    var equipmentList = dbContext.Equipments.ToList();
                    formFinishRequest.comboBoxEquipment.DisplayMember = "Model";
                    formFinishRequest.comboBoxEquipment.ValueMember = "EquipmentId";
                    formFinishRequest.comboBoxEquipment.DataSource = equipmentList;
                    var selectedEquipmentIndex = equipmentList.FindIndex(e => e.EquipmentId == requestToFinish.EquipmentId);
                    if (selectedEquipmentIndex >= 0)
                    {
                        formFinishRequest.comboBoxEquipment.SelectedIndex = selectedEquipmentIndex;
                        formFinishRequest.checkBoxEquipment.Checked = false;
                    }
                    else
                    {
                        formFinishRequest.comboBoxEquipment.SelectedIndex = 0; // Выбор первого элемента в коллекции
                        formFinishRequest.checkBoxEquipment.Checked = true;
                    }

                    var selectedEquipment = formFinishRequest.comboBoxEquipment.SelectedItem as Equipment;

                    if (selectedEquipment != null)
                    {
                        // Отображение цены выбранного оборудования
                        formFinishRequest.lblEquipmentPrice.Text = $"Цена: {selectedEquipment.SellingCost} руб";
                    }

                    DialogResult = formFinishRequest.ShowDialog(this);
                    if (DialogResult == DialogResult.Cancel) return;

                    // Получаем выбранное оборудование из FormFinishRequest
                    List<CartItem> selectedEquipmentList = formFinishRequest.SelectedEquipmentList;

                    // Получаем выбранные услуги из FormFinishRequest
                    List<TempInvoiceService> selectedInvoiceServices = formFinishRequest.temporaryInvoiceServices;

                    using (var transaction = dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            requestToFinish.RequestStatus = "Выполнена";

                           //Создание нового абонента
                           Subscriber subscriber = new Subscriber
                           {
                               FirstNameSubscriber = string.IsNullOrWhiteSpace(formFinishRequest.textBoxFirstName.Text) ? null : formFinishRequest.textBoxFirstName.Text,
                               MiddleNameSubscriber = string.IsNullOrWhiteSpace(formFinishRequest.textBoxMiddleName.Text) ? null : formFinishRequest.textBoxMiddleName.Text,
                               LastNameSubscriber = string.IsNullOrWhiteSpace(formFinishRequest.textBoxLastName.Text) ? null : formFinishRequest.textBoxLastName.Text,
                               PhoneSubscriber = string.IsNullOrWhiteSpace(formFinishRequest.textBoxPhone.Text) ? null : formFinishRequest.textBoxPhone.Text,
                               PassportSubscriber = string.IsNullOrWhiteSpace(formFinishRequest.textBoxPassport.Text) ? null : formFinishRequest.textBoxPassport.Text
                           };

                            // Добавление абонента в контекст базы данных
                            dbContext.Subscribers.Add(subscriber);
                            dbContext.SaveChanges();

                            // Создание нового договора
                            Contract contract = new Contract
                            {
                                SubscriberId = subscriber.SubscriberId,
                                StartDate = formFinishRequest.datePickerStart.Value,
                                EndDate = formFinishRequest.checkBoxUnlimited.Checked ? null : formFinishRequest.datePickerEnd.Value,
                                SubscriberLogin = formFinishRequest.textBoxLogin.Text,
                                SubscriberPassword = formFinishRequest.textBoxPassword.Text,
                                ConnectionAddress = formFinishRequest.textBoxAdress.Text,
                                IsSuspended = false
                            };

                            // Получение выбранного тарифа из ComboBox
                            Tariff selectedTariff = formFinishRequest.comboBoxTariff.SelectedItem as Tariff;
                            if (selectedTariff != null)
                            {
                                contract.TariffId = selectedTariff.TariffId;
                            }

                            // Добавление договора в контекст базы данных
                            dbContext.Contracts.Add(contract);
                            dbContext.SaveChanges();

                            // Добавление выбранного оборудования к текущему договору
                            if (selectedEquipmentList != null && selectedEquipmentList.Any())
                            {
                                foreach (var cartItem in selectedEquipmentList)
                                {
                                    Equipment equipmentToAdd = cartItem.SelectedEquipment;
                                    if (equipmentToAdd != null)
                                    {
                                        contract.Equipments.Add(equipmentToAdd);
                                    }
                                }
                                dbContext.SaveChanges();
                            }

                            // Создание нового счета
                            Invoice invoice = new Invoice
                            {
                                ContractId = contract.ContractId, // Привязываем счет к договору
                                InvoiceDate = DateTime.Now,
                                InvoiceAmount = selectedInvoiceServices.Sum(s => s.TotalCost), // Общая сумма счета
                                EmployeeId = this.employeeId
                            };

                            // Добавляем услуги к счету
                            foreach (var tempService in selectedInvoiceServices)
                            {
                                InvoiceService invoiceService = new InvoiceService
                                {
                                    ServiceId = tempService.Service.ServiceId,
                                    Amount = tempService.Quantity
                                };
                                invoice.InvoiceServices.Add(invoiceService);
                            }

                            // Добавляем счет к контексту базы данных
                            dbContext.Invoices.Add(invoice);
                            dbContext.SaveChanges();

                            transaction.Commit(); // Фиксация изменений в базе данных

                            LoadDataToDataGridView();
                            dataGridViewRequest.ClearSelection();
                            dataGridViewRequest.Rows[selectedIndex].Selected = true;

                            MessageBox.Show("Данные успешно добавлены");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                            transaction.Rollback(); // Откат транзакции в случае исключения
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выбранная заявка уже выполнена");
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
    }
}
