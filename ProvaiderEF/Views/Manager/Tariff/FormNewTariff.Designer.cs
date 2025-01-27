namespace ProvaiderEF
{
    partial class FormNewTariff
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
            lblTariff = new Label();
            textBoxName = new MyControls.CustomTextBox();
            lblName = new Label();
            lblSpeed = new Label();
            textBoxSpeed = new MyControls.CustomTextBox();
            lblCost = new Label();
            textBoxCost = new MyControls.CustomTextBox();
            lblDesc = new Label();
            textBoxDesc = new MyControls.CustomTextBox();
            lblType = new Label();
            comboBoxType = new MyControls.CustomComboBox();
            btnOK = new MyControls.CustomButton();
            btnCancel = new MyControls.CustomButton();
            SuspendLayout();
            // 
            // lblTariff
            // 
            lblTariff.Anchor = AnchorStyles.Top;
            lblTariff.AutoSize = true;
            lblTariff.Font = new Font("Century Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblTariff.ForeColor = Color.Gainsboro;
            lblTariff.Location = new Point(309, 47);
            lblTariff.Name = "lblTariff";
            lblTariff.Size = new Size(202, 63);
            lblTariff.TabIndex = 0;
            lblTariff.Text = "ТАРИФ";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.BackColor = Color.FromArgb(26, 25, 62);
            textBoxName.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxName.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxName.BorderRadius = 10;
            textBoxName.BorderSize = 2;
            textBoxName.ForeColor = Color.Gainsboro;
            textBoxName.Location = new Point(65, 209);
            textBoxName.Multiline = false;
            textBoxName.Name = "textBoxName";
            textBoxName.Padding = new Padding(18, 12, 18, 12);
            textBoxName.PasswordChar = false;
            textBoxName.PlaceholderColor = Color.DarkGray;
            textBoxName.PlaceholderText = "";
            textBoxName.Size = new Size(678, 57);
            textBoxName.TabIndex = 5;
            textBoxName.TextValue = "";
            textBoxName.UnderlinedStyle = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(65, 165);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 32);
            lblName.TabIndex = 6;
            lblName.Text = "Название*";
            // 
            // lblSpeed
            // 
            lblSpeed.Anchor = AnchorStyles.Top;
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeed.ForeColor = Color.White;
            lblSpeed.Location = new Point(65, 302);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(126, 32);
            lblSpeed.TabIndex = 8;
            lblSpeed.Text = "Скорость*";
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Anchor = AnchorStyles.Top;
            textBoxSpeed.BackColor = Color.FromArgb(26, 25, 62);
            textBoxSpeed.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxSpeed.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxSpeed.BorderRadius = 10;
            textBoxSpeed.BorderSize = 2;
            textBoxSpeed.ForeColor = Color.Gainsboro;
            textBoxSpeed.Location = new Point(65, 346);
            textBoxSpeed.Multiline = true;
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Padding = new Padding(18, 12, 18, 12);
            textBoxSpeed.PasswordChar = false;
            textBoxSpeed.PlaceholderColor = Color.DarkGray;
            textBoxSpeed.PlaceholderText = "";
            textBoxSpeed.Size = new Size(678, 60);
            textBoxSpeed.TabIndex = 7;
            textBoxSpeed.TextValue = "";
            textBoxSpeed.UnderlinedStyle = false;
            // 
            // lblCost
            // 
            lblCost.Anchor = AnchorStyles.Top;
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCost.ForeColor = Color.White;
            lblCost.Location = new Point(65, 441);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(141, 32);
            lblCost.TabIndex = 10;
            lblCost.Text = "Стоимость*";
            // 
            // textBoxCost
            // 
            textBoxCost.Anchor = AnchorStyles.Top;
            textBoxCost.BackColor = Color.FromArgb(26, 25, 62);
            textBoxCost.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxCost.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxCost.BorderRadius = 10;
            textBoxCost.BorderSize = 2;
            textBoxCost.ForeColor = Color.Gainsboro;
            textBoxCost.Location = new Point(65, 485);
            textBoxCost.Multiline = true;
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Padding = new Padding(18, 12, 18, 12);
            textBoxCost.PasswordChar = false;
            textBoxCost.PlaceholderColor = Color.DarkGray;
            textBoxCost.PlaceholderText = "";
            textBoxCost.Size = new Size(678, 60);
            textBoxCost.TabIndex = 9;
            textBoxCost.TextValue = "";
            textBoxCost.UnderlinedStyle = false;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top;
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(65, 586);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(124, 32);
            lblDesc.TabIndex = 12;
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
            textBoxDesc.Location = new Point(65, 630);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Padding = new Padding(18, 12, 18, 12);
            textBoxDesc.PasswordChar = false;
            textBoxDesc.PlaceholderColor = Color.DarkGray;
            textBoxDesc.PlaceholderText = "";
            textBoxDesc.Size = new Size(678, 163);
            textBoxDesc.TabIndex = 11;
            textBoxDesc.TextValue = "";
            textBoxDesc.UnderlinedStyle = false;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Top;
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(65, 833);
            lblType.Name = "lblType";
            lblType.Size = new Size(152, 32);
            lblType.TabIndex = 13;
            lblType.Text = "Тип оплаты*";
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.Top;
            comboBoxType.BackColor = Color.FromArgb(26, 25, 62);
            comboBoxType.BorderColor = Color.FromArgb(26, 25, 62);
            comboBoxType.BorderSize = 1;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.ForeColor = Color.Gainsboro;
            comboBoxType.IconColor = Color.FromArgb(119, 0, 255);
            comboBoxType.Items.AddRange(new object[] { "На месяц\t", "На год" });
            comboBoxType.ListBackColor = Color.FromArgb(31, 30, 68);
            comboBoxType.ListTextColor = Color.Gainsboro;
            comboBoxType.Location = new Point(65, 886);
            comboBoxType.MinimumSize = new Size(200, 30);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Padding = new Padding(18, 1, 18, 1);
            comboBoxType.Size = new Size(678, 60);
            comboBoxType.TabIndex = 14;
            comboBoxType.Texts = "На месяц";
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
            btnOK.Location = new Point(436, 1007);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 15;
            btnOK.Text = "OK";
            btnOK.TextColor = Color.Gainsboro;
            btnOK.UseVisualStyleBackColor = false;
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
            btnCancel.Location = new Point(601, 1007);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Отмена";
            btnCancel.TextColor = Color.FromArgb(119, 0, 255);
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormNewTariff
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 1175);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(comboBoxType);
            Controls.Add(lblType);
            Controls.Add(lblDesc);
            Controls.Add(textBoxDesc);
            Controls.Add(lblCost);
            Controls.Add(textBoxCost);
            Controls.Add(lblSpeed);
            Controls.Add(textBoxSpeed);
            Controls.Add(lblName);
            Controls.Add(textBoxName);
            Controls.Add(lblTariff);
            Name = "FormNewTariff";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewTariff";
            Load += CustomForm_Load;
            MouseDown += FormNewTariff_MouseDown;
            Resize += CustomForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTariff;
        private Label lblName;
        private Label lblSpeed;
        private Label lblCost;
        private Label lblDesc;
        private Label lblType;
        public MyControls.CustomTextBox textBoxName;
        public MyControls.CustomTextBox textBoxSpeed;
        public MyControls.CustomTextBox textBoxCost;
        public MyControls.CustomTextBox textBoxDesc;
        public MyControls.CustomComboBox comboBoxType;
        public MyControls.CustomButton btnOK;
        public MyControls.CustomButton btnCancel;
    }
}