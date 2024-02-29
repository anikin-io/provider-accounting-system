namespace ProvaiderEF
{
    partial class FormNewEquipment
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
            btnCancel = new MyControls.CustomButton();
            btnOK = new MyControls.CustomButton();
            lblSellingCost = new Label();
            textBoxSellingCost = new MyControls.CustomTextBox();
            lblModel = new Label();
            textBoxModel = new MyControls.CustomTextBox();
            lblEquipment = new Label();
            SuspendLayout();
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
            btnCancel.Location = new Point(597, 501);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 60);
            btnCancel.TabIndex = 29;
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
            btnOK.Location = new Point(432, 501);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 60);
            btnOK.TabIndex = 28;
            btnOK.Text = "OK";
            btnOK.TextColor = Color.Gainsboro;
            btnOK.UseVisualStyleBackColor = false;
            // 
            // lblSellingCost
            // 
            lblSellingCost.Anchor = AnchorStyles.Top;
            lblSellingCost.AutoSize = true;
            lblSellingCost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSellingCost.ForeColor = Color.White;
            lblSellingCost.Location = new Point(61, 332);
            lblSellingCost.Name = "lblSellingCost";
            lblSellingCost.Size = new Size(247, 32);
            lblSellingCost.TabIndex = 21;
            lblSellingCost.Text = "Стоимость продажи*";
            // 
            // textBoxSellingCost
            // 
            textBoxSellingCost.Anchor = AnchorStyles.Top;
            textBoxSellingCost.BackColor = Color.FromArgb(26, 25, 62);
            textBoxSellingCost.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxSellingCost.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxSellingCost.BorderRadius = 10;
            textBoxSellingCost.BorderSize = 2;
            textBoxSellingCost.ForeColor = Color.Gainsboro;
            textBoxSellingCost.Location = new Point(61, 376);
            textBoxSellingCost.Multiline = true;
            textBoxSellingCost.Name = "textBoxSellingCost";
            textBoxSellingCost.Padding = new Padding(18, 12, 18, 12);
            textBoxSellingCost.PasswordChar = false;
            textBoxSellingCost.PlaceholderColor = Color.DarkGray;
            textBoxSellingCost.PlaceholderText = "";
            textBoxSellingCost.Size = new Size(678, 60);
            textBoxSellingCost.TabIndex = 20;
            textBoxSellingCost.TextValue = "";
            textBoxSellingCost.UnderlinedStyle = false;
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Top;
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblModel.ForeColor = Color.White;
            lblModel.Location = new Point(61, 195);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(111, 32);
            lblModel.TabIndex = 19;
            lblModel.Text = "Модель*";
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.Top;
            textBoxModel.BackColor = Color.FromArgb(26, 25, 62);
            textBoxModel.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxModel.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxModel.BorderRadius = 10;
            textBoxModel.BorderSize = 2;
            textBoxModel.ForeColor = Color.Gainsboro;
            textBoxModel.Location = new Point(61, 239);
            textBoxModel.Multiline = false;
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Padding = new Padding(18, 12, 18, 12);
            textBoxModel.PasswordChar = false;
            textBoxModel.PlaceholderColor = Color.DarkGray;
            textBoxModel.PlaceholderText = "";
            textBoxModel.Size = new Size(678, 57);
            textBoxModel.TabIndex = 18;
            textBoxModel.TextValue = "";
            textBoxModel.UnderlinedStyle = false;
            // 
            // lblEquipment
            // 
            lblEquipment.Anchor = AnchorStyles.Top;
            lblEquipment.AutoSize = true;
            lblEquipment.Font = new Font("Century Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblEquipment.ForeColor = Color.Gainsboro;
            lblEquipment.Location = new Point(178, 77);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(470, 63);
            lblEquipment.TabIndex = 17;
            lblEquipment.Text = "ОБОРУДОВАНИЕ";
            // 
            // FormNewEquipment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 665);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblSellingCost);
            Controls.Add(textBoxSellingCost);
            Controls.Add(lblModel);
            Controls.Add(textBoxModel);
            Controls.Add(lblEquipment);
            Name = "FormNewEquipment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewEquipment";
            Load += CustomForm_Load;
            MouseDown += FormNewEquipment_MouseDown;
            Resize += CustomForm_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MyControls.CustomButton btnCancel;
        public MyControls.CustomButton btnOK;
        private Label lblSellingCost;
        public MyControls.CustomTextBox textBoxSellingCost;
        private Label lblModel;
        public MyControls.CustomTextBox textBoxModel;
        private Label lblEquipment;
    }
}