namespace ProvaiderEF
{
    partial class FormNewRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRequest = new Label();
            btnCancel = new MyControls.CustomButton();
            btnOK = new MyControls.CustomButton();
            comboBoxTariff = new MyControls.CustomComboBox();
            lblTariff = new Label();
            lblDesc = new Label();
            textBoxDesc = new MyControls.CustomTextBox();
            lblMiddleName = new Label();
            textBoxMiddleName = new MyControls.CustomTextBox();
            lblFirstName = new Label();
            textBoxFirstName = new MyControls.CustomTextBox();
            lblLastName = new Label();
            textBoxLastName = new MyControls.CustomTextBox();
            lblPhone = new Label();
            textBoxPhone = new MyControls.CustomTextBox();
            lblAdress = new Label();
            textBoxAdress = new MyControls.CustomTextBox();
            comboBoxEquipment = new MyControls.CustomComboBox();
            lblEquipment = new Label();
            comboBoxStatus = new MyControls.CustomComboBox();
            lblStatus = new Label();
            checkBoxEquipment = new CheckBox();
            datePickerRequest = new MyControls.CustomDatePicker();
            lblDate = new Label();
            timePickerRequest = new MyControls.CustomTimePicker();
            SuspendLayout();
            // 
            // lblRequest
            // 
            lblRequest.Anchor = AnchorStyles.Top;
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Century Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequest.ForeColor = Color.Gainsboro;
            lblRequest.Location = new Point(292, 47);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(224, 63);
            lblRequest.TabIndex = 12;
            lblRequest.Text = "ЗАЯВКА";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.FromArgb(34, 33, 74);
            btnCancel.BackgroundColor = Color.FromArgb(34, 33, 74);
            btnCancel.BorderColor = Color.FromArgb(119, 0, 255);
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 2;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(119, 0, 255);
            btnCancel.Location = new Point(597, 1657);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Отмена";
            btnCancel.TextColor = Color.FromArgb(119, 0, 255);
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top;
            btnOK.BackColor = Color.FromArgb(119, 0, 255);
            btnOK.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnOK.BorderColor = Color.FromArgb(128, 128, 255);
            btnOK.BorderRadius = 10;
            btnOK.BorderSize = 0;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = Color.Gainsboro;
            btnOK.Location = new Point(432, 1657);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 27;
            btnOK.Text = "OK";
            btnOK.TextColor = Color.Gainsboro;
            btnOK.UseVisualStyleBackColor = false;
            // 
            // comboBoxTariff
            // 
            comboBoxTariff.Anchor = AnchorStyles.Top;
            comboBoxTariff.BackColor = Color.FromArgb(26, 25, 62);
            comboBoxTariff.BorderColor = Color.FromArgb(26, 25, 62);
            comboBoxTariff.BorderSize = 1;
            comboBoxTariff.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTariff.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTariff.ForeColor = Color.Gainsboro;
            comboBoxTariff.IconColor = Color.FromArgb(119, 0, 255);
            comboBoxTariff.ListBackColor = Color.FromArgb(31, 30, 68);
            comboBoxTariff.ListTextColor = Color.Gainsboro;
            comboBoxTariff.Location = new Point(61, 877);
            comboBoxTariff.MinimumSize = new Size(200, 30);
            comboBoxTariff.Name = "comboBoxTariff";
            comboBoxTariff.Padding = new Padding(18, 1, 18, 1);
            comboBoxTariff.Size = new Size(678, 60);
            comboBoxTariff.TabIndex = 26;
            comboBoxTariff.Texts = "";
            // 
            // lblTariff
            // 
            lblTariff.Anchor = AnchorStyles.Top;
            lblTariff.AutoSize = true;
            lblTariff.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTariff.ForeColor = Color.White;
            lblTariff.Location = new Point(61, 824);
            lblTariff.Name = "lblTariff";
            lblTariff.Size = new Size(93, 32);
            lblTariff.TabIndex = 25;
            lblTariff.Text = "Тариф*";
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top;
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(61, 1452);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(124, 32);
            lblDesc.TabIndex = 24;
            lblDesc.Text = "Описание";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Anchor = AnchorStyles.Top;
            textBoxDesc.BackColor = Color.FromArgb(26, 25, 62);
            textBoxDesc.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxDesc.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxDesc.BorderRadius = 10;
            textBoxDesc.BorderSize = 2;
            textBoxDesc.ForeColor = Color.Gainsboro;
            textBoxDesc.Location = new Point(61, 1496);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Padding = new Padding(18, 12, 18, 12);
            textBoxDesc.PasswordChar = false;
            textBoxDesc.PlaceholderColor = Color.DarkGray;
            textBoxDesc.PlaceholderText = "";
            textBoxDesc.Size = new Size(678, 109);
            textBoxDesc.TabIndex = 23;
            textBoxDesc.TextValue = "";
            textBoxDesc.UnderlinedStyle = false;
            // 
            // lblMiddleName
            // 
            lblMiddleName.Anchor = AnchorStyles.Top;
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMiddleName.ForeColor = Color.White;
            lblMiddleName.Location = new Point(61, 404);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(117, 32);
            lblMiddleName.TabIndex = 22;
            lblMiddleName.Text = "Отчество";
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Anchor = AnchorStyles.Top;
            textBoxMiddleName.BackColor = Color.FromArgb(26, 25, 62);
            textBoxMiddleName.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxMiddleName.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxMiddleName.BorderRadius = 10;
            textBoxMiddleName.BorderSize = 2;
            textBoxMiddleName.ForeColor = Color.Gainsboro;
            textBoxMiddleName.Location = new Point(61, 448);
            textBoxMiddleName.Multiline = true;
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Padding = new Padding(18, 12, 18, 12);
            textBoxMiddleName.PasswordChar = false;
            textBoxMiddleName.PlaceholderColor = Color.DarkGray;
            textBoxMiddleName.PlaceholderText = "";
            textBoxMiddleName.Size = new Size(678, 60);
            textBoxMiddleName.TabIndex = 21;
            textBoxMiddleName.TextValue = "";
            textBoxMiddleName.UnderlinedStyle = false;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(61, 269);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 32);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "Имя*";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Top;
            textBoxFirstName.BackColor = Color.FromArgb(26, 25, 62);
            textBoxFirstName.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxFirstName.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxFirstName.BorderRadius = 10;
            textBoxFirstName.BorderSize = 2;
            textBoxFirstName.ForeColor = Color.Gainsboro;
            textBoxFirstName.Location = new Point(61, 313);
            textBoxFirstName.Multiline = true;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Padding = new Padding(18, 12, 18, 12);
            textBoxFirstName.PasswordChar = false;
            textBoxFirstName.PlaceholderColor = Color.DarkGray;
            textBoxFirstName.PlaceholderText = "";
            textBoxFirstName.Size = new Size(678, 60);
            textBoxFirstName.TabIndex = 19;
            textBoxFirstName.TextValue = "";
            textBoxFirstName.UnderlinedStyle = false;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(61, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(123, 32);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Фамилия*";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top;
            textBoxLastName.BackColor = Color.FromArgb(26, 25, 62);
            textBoxLastName.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxLastName.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxLastName.BorderRadius = 10;
            textBoxLastName.BorderSize = 2;
            textBoxLastName.ForeColor = Color.Gainsboro;
            textBoxLastName.Location = new Point(61, 180);
            textBoxLastName.Multiline = false;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Padding = new Padding(18, 12, 18, 12);
            textBoxLastName.PasswordChar = false;
            textBoxLastName.PlaceholderColor = Color.DarkGray;
            textBoxLastName.PlaceholderText = "";
            textBoxLastName.Size = new Size(678, 57);
            textBoxLastName.TabIndex = 17;
            textBoxLastName.TextValue = "";
            textBoxLastName.UnderlinedStyle = false;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(61, 545);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 32);
            lblPhone.TabIndex = 30;
            lblPhone.Text = "Телефон*";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top;
            textBoxPhone.BackColor = Color.FromArgb(26, 25, 62);
            textBoxPhone.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxPhone.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxPhone.BorderRadius = 10;
            textBoxPhone.BorderSize = 2;
            textBoxPhone.ForeColor = Color.Gainsboro;
            textBoxPhone.Location = new Point(61, 589);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Padding = new Padding(18, 12, 18, 12);
            textBoxPhone.PasswordChar = false;
            textBoxPhone.PlaceholderColor = Color.DarkGray;
            textBoxPhone.PlaceholderText = "";
            textBoxPhone.Size = new Size(678, 60);
            textBoxPhone.TabIndex = 29;
            textBoxPhone.TextValue = "";
            textBoxPhone.UnderlinedStyle = false;
            // 
            // lblAdress
            // 
            lblAdress.Anchor = AnchorStyles.Top;
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdress.ForeColor = Color.White;
            lblAdress.Location = new Point(61, 681);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(90, 32);
            lblAdress.TabIndex = 32;
            lblAdress.Text = "Адрес*";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Anchor = AnchorStyles.Top;
            textBoxAdress.BackColor = Color.FromArgb(26, 25, 62);
            textBoxAdress.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxAdress.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxAdress.BorderRadius = 10;
            textBoxAdress.BorderSize = 2;
            textBoxAdress.ForeColor = Color.Gainsboro;
            textBoxAdress.Location = new Point(61, 726);
            textBoxAdress.Multiline = true;
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Padding = new Padding(18, 12, 18, 12);
            textBoxAdress.PasswordChar = false;
            textBoxAdress.PlaceholderColor = Color.DarkGray;
            textBoxAdress.PlaceholderText = "";
            textBoxAdress.Size = new Size(678, 60);
            textBoxAdress.TabIndex = 31;
            textBoxAdress.TextValue = "";
            textBoxAdress.UnderlinedStyle = false;
            // 
            // comboBoxEquipment
            // 
            comboBoxEquipment.Anchor = AnchorStyles.Top;
            comboBoxEquipment.BackColor = Color.FromArgb(26, 25, 62);
            comboBoxEquipment.BorderColor = Color.FromArgb(26, 25, 62);
            comboBoxEquipment.BorderSize = 1;
            comboBoxEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEquipment.ForeColor = Color.Gainsboro;
            comboBoxEquipment.IconColor = Color.FromArgb(119, 0, 255);
            comboBoxEquipment.ListBackColor = Color.FromArgb(31, 30, 68);
            comboBoxEquipment.ListTextColor = Color.Gainsboro;
            comboBoxEquipment.Location = new Point(61, 1027);
            comboBoxEquipment.MinimumSize = new Size(200, 30);
            comboBoxEquipment.Name = "comboBoxEquipment";
            comboBoxEquipment.Padding = new Padding(18, 1, 18, 1);
            comboBoxEquipment.Size = new Size(678, 60);
            comboBoxEquipment.TabIndex = 34;
            comboBoxEquipment.Texts = "";
            // 
            // lblEquipment
            // 
            lblEquipment.Anchor = AnchorStyles.Top;
            lblEquipment.AutoSize = true;
            lblEquipment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEquipment.ForeColor = Color.White;
            lblEquipment.Location = new Point(61, 974);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(179, 32);
            lblEquipment.TabIndex = 33;
            lblEquipment.Text = "Оборудование";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Top;
            comboBoxStatus.BackColor = Color.FromArgb(26, 25, 62);
            comboBoxStatus.BorderColor = Color.FromArgb(26, 25, 62);
            comboBoxStatus.BorderSize = 1;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.ForeColor = Color.Gainsboro;
            comboBoxStatus.IconColor = Color.FromArgb(119, 0, 255);
            comboBoxStatus.ListBackColor = Color.FromArgb(31, 30, 68);
            comboBoxStatus.ListTextColor = Color.Gainsboro;
            comboBoxStatus.Location = new Point(61, 1221);
            comboBoxStatus.MinimumSize = new Size(200, 30);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Padding = new Padding(18, 1, 18, 1);
            comboBoxStatus.Size = new Size(678, 60);
            comboBoxStatus.TabIndex = 36;
            comboBoxStatus.Texts = "";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(61, 1168);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 32);
            lblStatus.TabIndex = 35;
            lblStatus.Text = "Статус*";
            // 
            // checkBoxEquipment
            // 
            checkBoxEquipment.AutoSize = true;
            checkBoxEquipment.ForeColor = Color.Gainsboro;
            checkBoxEquipment.Location = new Point(61, 1098);
            checkBoxEquipment.Name = "checkBoxEquipment";
            checkBoxEquipment.Size = new Size(192, 36);
            checkBoxEquipment.TabIndex = 37;
            checkBoxEquipment.Text = "Не требуется";
            checkBoxEquipment.UseVisualStyleBackColor = true;
            checkBoxEquipment.CheckedChanged += checkBoxEquipment_CheckedChanged;
            // 
            // datePickerRequest
            // 
            datePickerRequest.Anchor = AnchorStyles.Top;
            datePickerRequest.BorderColor = Color.FromArgb(119, 0, 255);
            datePickerRequest.BorderSize = 0;
            datePickerRequest.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerRequest.CalendarForeColor = Color.White;
            datePickerRequest.CalendarMonthBackground = Color.FromArgb(26, 25, 62);
            datePickerRequest.CalendarTitleForeColor = Color.White;
            datePickerRequest.CalendarTrailingForeColor = Color.Gainsboro;
            datePickerRequest.CustomFormat = "dd/MM/yyyy";
            datePickerRequest.DropDownAlign = LeftRightAlignment.Right;
            datePickerRequest.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datePickerRequest.ImeMode = ImeMode.On;
            datePickerRequest.Location = new Point(61, 1362);
            datePickerRequest.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            datePickerRequest.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            datePickerRequest.MinimumSize = new Size(0, 60);
            datePickerRequest.Name = "datePickerRequest";
            datePickerRequest.Size = new Size(513, 60);
            datePickerRequest.SkinColor = Color.FromArgb(26, 25, 62);
            datePickerRequest.TabIndex = 38;
            datePickerRequest.TextColor = Color.Gainsboro;
            datePickerRequest.Value = new DateTime(2023, 11, 30, 22, 32, 30, 0);
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(61, 1314);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(253, 32);
            lblDate.TabIndex = 39;
            lblDate.Text = "Дата и время заявки*";
            // 
            // timePickerRequest
            // 
            timePickerRequest.CustomBackColor = Color.FromArgb(26, 25, 62);
            timePickerRequest.CustomFormat = "HH:mm";
            timePickerRequest.CustomTextColor = Color.Gainsboro;
            timePickerRequest.Format = DateTimePickerFormat.Custom;
            timePickerRequest.Location = new Point(601, 1362);
            timePickerRequest.MinimumSize = new Size(0, 60);
            timePickerRequest.Name = "timePickerRequest";
            timePickerRequest.ShowUpDown = true;
            timePickerRequest.Size = new Size(138, 60);
            timePickerRequest.TabIndex = 41;
            // 
            // FormNewRequest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 1777);
            Controls.Add(timePickerRequest);
            Controls.Add(lblDate);
            Controls.Add(datePickerRequest);
            Controls.Add(checkBoxEquipment);
            Controls.Add(comboBoxStatus);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxEquipment);
            Controls.Add(lblEquipment);
            Controls.Add(lblAdress);
            Controls.Add(textBoxAdress);
            Controls.Add(lblPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(comboBoxTariff);
            Controls.Add(lblTariff);
            Controls.Add(lblDesc);
            Controls.Add(textBoxDesc);
            Controls.Add(lblMiddleName);
            Controls.Add(textBoxMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(textBoxFirstName);
            Controls.Add(lblLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(lblRequest);
            Name = "FormNewRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewRequest";
            Load += CustomForm_Load;
            MouseDown += FormNewRequest_MouseDown;
            Resize += CustomForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRequest;
        public MyControls.CustomButton btnCancel;
        public MyControls.CustomButton btnOK;
        public MyControls.CustomComboBox comboBoxTariff;
        private Label lblType;
        private Label lblDesc;
        public MyControls.CustomTextBox textBoxDesc;
        private Label lblMiddleName;
        public MyControls.CustomTextBox textBoxMiddleName;
        private Label lblFirstName;
        public MyControls.CustomTextBox textBoxFirstName;
        private Label lblLastName;
        public MyControls.CustomTextBox textBoxLastName;
        private Label lblPhone;
        public MyControls.CustomTextBox textBoxPhone;
        private Label lblAdress;
        public MyControls.CustomTextBox textBoxAdress;
        public MyControls.CustomComboBox comboBoxEquipment;
        private Label lblEquipment;
        public MyControls.CustomComboBox comboBoxStatus;
        private Label lblStatus;
        private Label lblTariff;
        public CheckBox checkBoxEquipment;
        private Label lblDate;
        public MyControls.CustomDatePicker datePickerRequest;
        public MyControls.CustomTimePicker timePickerRequest;
    }
}