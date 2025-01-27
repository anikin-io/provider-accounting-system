namespace ProvaiderEF
{
    partial class FormEquipment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnDelete = new MyControls.CustomButton();
            btnUpdate = new MyControls.CustomButton();
            btnInsert = new MyControls.CustomButton();
            textBoxSearch = new MyControls.CustomTextBox();
            btnSearch = new MyControls.CustomButton();
            dataGridViewEquipment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(119, 0, 255);
            btnDelete.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnDelete.BorderColor = Color.FromArgb(128, 128, 255);
            btnDelete.BorderRadius = 30;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Gainsboro;
            btnDelete.Location = new Point(1353, 38);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 60);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить";
            btnDelete.TextColor = Color.Gainsboro;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(119, 0, 255);
            btnUpdate.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnUpdate.BorderColor = Color.FromArgb(128, 128, 255);
            btnUpdate.BorderRadius = 30;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Gainsboro;
            btnUpdate.Location = new Point(1168, 38);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 60);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Обновить";
            btnUpdate.TextColor = Color.Gainsboro;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInsert.BackColor = Color.FromArgb(119, 0, 255);
            btnInsert.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnInsert.BorderColor = Color.FromArgb(128, 128, 255);
            btnInsert.BorderRadius = 30;
            btnInsert.BorderSize = 0;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.Gainsboro;
            btnInsert.Location = new Point(981, 39);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(168, 60);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Добавить";
            btnInsert.TextColor = Color.Gainsboro;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(26, 25, 62);
            textBoxSearch.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxSearch.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxSearch.BorderRadius = 30;
            textBoxSearch.BorderSize = 2;
            textBoxSearch.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.ForeColor = Color.Gainsboro;
            textBoxSearch.Location = new Point(30, 39);
            textBoxSearch.Multiline = false;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Padding = new Padding(25, 12, 25, 12);
            textBoxSearch.PasswordChar = false;
            textBoxSearch.PlaceholderColor = Color.DarkGray;
            textBoxSearch.PlaceholderText = "Введите поисковый запрос";
            textBoxSearch.Size = new Size(564, 55);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextValue = "Введите поисковый запрос";
            textBoxSearch.UnderlinedStyle = false;
            textBoxSearch._TextChanged += TextBoxSearch__TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(119, 0, 255);
            btnSearch.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnSearch.BorderColor = Color.MediumPurple;
            btnSearch.BorderRadius = 30;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search32;
            btnSearch.Location = new Point(606, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 60);
            btnSearch.TabIndex = 7;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewEquipment
            // 
            dataGridViewEquipment.AllowUserToAddRows = false;
            dataGridViewEquipment.AllowUserToDeleteRows = false;
            dataGridViewEquipment.AllowUserToOrderColumns = true;
            dataGridViewEquipment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 25, 62);
            dataGridViewEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEquipment.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridViewEquipment.BorderStyle = BorderStyle.None;
            dataGridViewEquipment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewEquipment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEquipment.ColumnHeadersHeight = 60;
            dataGridViewEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(58, 56, 126);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEquipment.EnableHeadersVisualStyles = false;
            dataGridViewEquipment.Location = new Point(30, 144);
            dataGridViewEquipment.Name = "dataGridViewEquipment";
            dataGridViewEquipment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewEquipment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEquipment.RowHeadersVisible = false;
            dataGridViewEquipment.RowHeadersWidth = 82;
            dataGridViewEquipment.RowTemplate.Height = 60;
            dataGridViewEquipment.ScrollBars = ScrollBars.Vertical;
            dataGridViewEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipment.Size = new Size(1483, 715);
            dataGridViewEquipment.TabIndex = 6;
            dataGridViewEquipment.CellFormatting += dataGridViewEquipment_CellFormatting;
            // 
            // FormEquipment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 897);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewEquipment);
            Name = "FormEquipment";
            Text = "Оборудование";
            Load += FormEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private MyControls.CustomButton btnDelete;
        private MyControls.CustomButton btnUpdate;
        private MyControls.CustomButton btnInsert;
        private MyControls.CustomTextBox textBoxSearch;
        private MyControls.CustomButton btnSearch;
        private DataGridView dataGridViewEquipment;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalTypeDataGridViewTextBoxColumn;
    }
}