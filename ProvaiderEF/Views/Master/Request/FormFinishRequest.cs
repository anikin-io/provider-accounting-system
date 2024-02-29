using FontAwesome.Sharp;
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
    public partial class FormFinishRequest : FormAbstractClass
    {
        public MyContext dbContext { get; private set; }

        // Объявление полей для хранения текущей панели и кнопок
        private Panel[] panels;
        private IconButton[] topMenuButtons;

        public FormFinishRequest()
        {
            InitializeComponent();
            //InitializeIconButtons();

            // Инициализация массивов панелей и кнопок
            panels = new Panel[] { panelDesktop1, panelDesktop2, panelDesktop3, panelDesktop4 };
            topMenuButtons = new IconButton[] { btnFirstStep, btnSecondStep, btnThirdStep, btnFourthStep };

            // Устанавливаем начальную панель и кнопки
            SetActivePanel(0);
            SetActiveTopMenuButton(0);

            dbContext = new MyContext();
        }

        private void SetActivePanel(int panelIndex)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].Visible = (i == panelIndex);
                panelBack.Dock = DockStyle.Top;
                panelButtons.Dock = DockStyle.Top;
                panels[i].Dock = DockStyle.Fill;
            }
        }

        private void SetActiveTopMenuButton(int buttonIndex)
        {
            for (int i = 0; i < topMenuButtons.Length; i++)
            {
                topMenuButtons[i].BackColor = Color.FromArgb(26, 25, 62);
            }

            topMenuButtons[buttonIndex].BackColor = Color.FromArgb(119, 0, 255);
        }

        private void btnFirstStep_Click(object sender, EventArgs e)
        {
            SetActivePanel(0);
            SetActiveTopMenuButton(0);
        }

        private void btnSecondStep_Click(object sender, EventArgs e)
        {
            SetActivePanel(1);
            SetActiveTopMenuButton(1);
        }

        private void btnThirdStep_Click(object sender, EventArgs e)
        {
            SetActivePanel(2);
            SetActiveTopMenuButton(2);
        }

        private void btnFourthStep_Click(object sender, EventArgs e)
        {
            SetActivePanel(3);
            SetActiveTopMenuButton(3);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            SetActivePanel(1);
            SetActiveTopMenuButton(1);
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            SetActivePanel(2);
            SetActiveTopMenuButton(2);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            SetActivePanel(0);
            SetActiveTopMenuButton(0);
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            SetActivePanel(3);
            SetActiveTopMenuButton(3);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            SetActivePanel(1);
            SetActiveTopMenuButton(1);
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            SetActivePanel(2);
            SetActiveTopMenuButton(2);
        }

        private void comboBoxEquipment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEquipment = comboBoxEquipment.SelectedItem as Equipment;

            if (selectedEquipment != null)
            {
                // Отображение цены выбранного оборудования
                lblEquipmentPrice.Text = $"Цена: {selectedEquipment.SellingCost} руб";
            }         
        }

        // Создание временного списка, который будет хранить информацию о выбранных элементах корзины
        List<CartItem> temporaryCartItems = new List<CartItem>();
        public List<CartItem> SelectedEquipmentList { get; private set; }

        // Обновление списка listBoxCart на основе временного списка
        private void UpdateCartListBox()
        {
            listBoxCart.Items.Clear();

            foreach (var item in temporaryCartItems)
            {
                string displayText = $"{item.SelectedEquipment.Model} - ";

                displayText += $"покупка {item.SelectedEquipment.SellingCost} руб";

                listBoxCart.Items.Add(displayText);
            }

            SelectedEquipmentList = temporaryCartItems; // Передача списка выбранного оборудования обратно в FormRequestMaster
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {
            var selectedEquipment = comboBoxEquipment.SelectedItem as Equipment;

            CartItem cartItem = new CartItem();
            cartItem.SelectedEquipment = selectedEquipment;

            temporaryCartItems.Add(cartItem);
            UpdateCartListBox();
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex != -1)
            {
                temporaryCartItems.RemoveAt(listBoxCart.SelectedIndex);
                UpdateCartListBox();
            }
        }

        private void checkBoxEquipment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEquipment.Checked)
            {
                comboBoxEquipment.Enabled = false;
                lblEquipmentPrice.Enabled = false;
                temporaryCartItems.Clear();
                UpdateCartListBox();
                listBoxCart.Enabled = false;
                btnToCart.Enabled = false;
                btnDeleteCart.Enabled = false;
            }
            else
            {
                comboBoxEquipment.Enabled = true;
                lblEquipmentPrice.Enabled = true;
                listBoxCart.Enabled = true;
                btnToCart.Enabled = true;
                btnDeleteCart.Enabled = true;
            }
        }

        protected override void CustomForm_Load(object sender, EventArgs e)
        {
            base.CustomForm_Load(sender, e);

            numericUpDown1.Tag = 0; // Устанавливаем тег для первого numericUpDown для первой услуги (индекс 0)
            numericUpDown2.Tag = 1; // Устанавливаем тег для второго numericUpDown для второй услуги (индекс 1)
            numericUpDown3.Tag = 2; // Устанавливаем тег для третьего numericUpDown для третьей услуги (индекс 2)

            // Пример подключения обработчика события ValueChanged для numericUpDown1
            numericUpDown1.ValueChanged += numericUpDown_ValueChanged;

            // Пример подключения обработчика события ValueChanged для numericUpDown2
            numericUpDown2.ValueChanged += numericUpDown_ValueChanged;

            // Пример подключения обработчика события ValueChanged для numericUpDown3
            numericUpDown3.ValueChanged += numericUpDown_ValueChanged;

            datePickerStart.Value = DateTime.Now;
        }

        // Получение данных о типах услуг из БД и их отображение в лейблах lblServicesN1, lblServicesN2, lblServicesN3
        //public void DisplayServiceTypes()
        //{
        //    var services = dbContext.Services.Take(3).ToList();

        //    if (services.Count >= 1)
        //    {
        //        lblServicesN1.Text = services[0].ServiceType;
        //    }
        //    if (services.Count >= 2)
        //    {
        //        lblServicesN2.Text = services[1].ServiceType;
        //    }
        //    if (services.Count >= 3)
        //    {
        //        lblServicesN3.Text = services[2].ServiceType;
        //    }
        //}

        //// Обновление лейбла с итоговой суммой с форматированием
        //private void UpdateTotalWithFormat(Label totalLabel, decimal total)
        //{
        //    string formattedTotal = total.ToString("0.##") + " ₽"; // Форматирование без нулей после запятой и добавление знака рубля
        //    totalLabel.Text = formattedTotal;
        //}

        //// Метод для рассчета суммы и отображения в соответствующем лейбле с форматированием
        //private void CalculateAndUpdateTotal(Label totalLabel, decimal serviceCost, int quantity)
        //{
        //    decimal total = serviceCost * quantity;
        //    UpdateTotalWithFormat(totalLabel, total);
        //}

        // Получение стоимости услуги по индексу
        private decimal GetServiceCostForIndex(int index)
        {
            var service = dbContext.Services.Skip(index).FirstOrDefault(); // Получаем соответствующую услугу по индексу
            return service?.ServiceCost ?? 0m; // Возвращаем ServiceCost, если услуга найдена, иначе 0
        }

        // Объявление списка для хранения информации о выбранных услугах на счете
        public List<TempInvoiceService> temporaryInvoiceServices = new List<TempInvoiceService>();

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            int index = Convert.ToInt32(numericUpDown.Tag); // Получаем индекс услуги из тега numericUpDown

            int quantity = (int)numericUpDown.Value;
            decimal serviceCost = GetServiceCostForIndex(index);

            // Обновление временного хранилища информацией о выбранной услуге
            var selectedService = dbContext.Services.Skip(index).FirstOrDefault(); // Получение выбранной услуги из БД
            if (selectedService != null)
            {
                TempInvoiceService tempService = temporaryInvoiceServices.FirstOrDefault(s => s.Service.ServiceId == selectedService.ServiceId);
                if (tempService != null)
                {
                    tempService.Quantity = quantity; // Обновляем количество услуг во временном хранилище
                    tempService.TotalCost = quantity * serviceCost; // Обновляем общую стоимость во временном хранилище
                }
                else
                {
                    tempService = new TempInvoiceService
                    {
                        Service = selectedService,
                        Quantity = quantity,
                        TotalCost = quantity * serviceCost
                    };
                    temporaryInvoiceServices.Add(tempService); // Добавляем новую выбранную услугу во временное хранилище
                }
            }

            UpdateTotalInvoiceAmountLabel(); // Вызываем метод для обновления итоговой суммы
            UpdateServiceTotalLabel(index + 1, quantity * serviceCost); // Вызываем метод для обновления лейбла суммы по услуге
        }
        private void UpdateTotalInvoiceAmountLabel()
        {
            decimal totalInvoiceAmount = temporaryInvoiceServices.Sum(s => s.TotalCost); // Подсчет общей суммы по всем услугам

            string formattedTotalAmount = $"Всего работ на сумму: {totalInvoiceAmount.ToString("0.##")} ₽";
            lblResult.Text = formattedTotalAmount;
        }

        // Метод для обновления лейбла суммы по каждой услуге
        private void UpdateServiceTotalLabel(int labelIndex, decimal total)
        {
            if (labelIndex == 1)
            {
                lblSumN1.Text = $"{total.ToString("0.##")} ₽";
            }
            else if (labelIndex == 2)
            {
                lblSumN2.Text = $"{total.ToString("0.##")} ₽";
            }
            else if (labelIndex == 3)
            {
                lblSumN3.Text = $"{total.ToString("0.##")} ₽";
            }
        }

        private void checkBoxUnlimited_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnlimited.Checked)
            {
                datePickerEnd.Enabled = false;
            }
            else
            {
                datePickerEnd.Enabled = true;
            }
        }

        private void panelBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void CustomForm_Resize(object sender, EventArgs e)
        {
            base.CustomForm_Resize(sender, e);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
