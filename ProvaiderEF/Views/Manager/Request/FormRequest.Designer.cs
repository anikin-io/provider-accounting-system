namespace ProvaiderEF
{
    partial class FormRequest
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnDelete = new MyControls.CustomButton();
            btnUpdate = new MyControls.CustomButton();
            btnInsert = new MyControls.CustomButton();
            textBoxSearch = new MyControls.CustomTextBox();
            btnSearch = new MyControls.CustomButton();
            dataGridViewRequest = new DataGridView();
            comboBoxFilter = new MyControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).BeginInit();
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
            btnDelete.Location = new Point(1645, 38);
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
            btnUpdate.Location = new Point(1460, 38);
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
            btnInsert.Location = new Point(1273, 39);
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
            textBoxSearch._TextChanged += textBoxSearch__TextChanged;
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
            // dataGridViewRequest
            // 
            dataGridViewRequest.AllowUserToAddRows = false;
            dataGridViewRequest.AllowUserToDeleteRows = false;
            dataGridViewRequest.AllowUserToOrderColumns = true;
            dataGridViewRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 25, 62);
            dataGridViewRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequest.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridViewRequest.BorderStyle = BorderStyle.None;
            dataGridViewRequest.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewRequest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewRequest.ColumnHeadersHeight = 60;
            dataGridViewRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(58, 56, 126);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewRequest.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewRequest.EnableHeadersVisualStyles = false;
            dataGridViewRequest.Location = new Point(30, 144);
            dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewRequest.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewRequest.RowHeadersVisible = false;
            dataGridViewRequest.RowHeadersWidth = 82;
            dataGridViewRequest.RowTemplate.Height = 60;
            dataGridViewRequest.ScrollBars = ScrollBars.Vertical;
            dataGridViewRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequest.Size = new Size(1775, 715);
            dataGridViewRequest.TabIndex = 6;
            dataGridViewRequest.CellFormatting += dataGridViewRequest_CellFormatting;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = Color.FromArgb(26, 25, 62);
            comboBoxFilter.BorderColor = Color.FromArgb(26, 25, 62);
            comboBoxFilter.BorderSize = 1;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilter.ForeColor = Color.Gainsboro;
            comboBoxFilter.IconColor = Color.FromArgb(119, 0, 255);
            comboBoxFilter.ListBackColor = Color.FromArgb(31, 30, 68);
            comboBoxFilter.ListTextColor = Color.Gainsboro;
            comboBoxFilter.Location = new Point(722, 39);
            comboBoxFilter.MinimumSize = new Size(200, 30);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Padding = new Padding(18, 1, 18, 1);
            comboBoxFilter.Size = new Size(270, 55);
            comboBoxFilter.TabIndex = 15;
            comboBoxFilter.Texts = "";
            comboBoxFilter.OnSelectedIndexChanged += comboBoxFilter_OnSelectedIndexChanged;
            // 
            // FormRequest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1834, 897);
            Controls.Add(comboBoxFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewRequest);
            Name = "FormRequest";
            Text = "Заявки";
            Load += FormRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MyControls.CustomButton btnDelete;
        private MyControls.CustomButton btnUpdate;
        private MyControls.CustomButton btnInsert;
        private MyControls.CustomTextBox textBoxSearch;
        private MyControls.CustomButton btnSearch;
        private DataGridView dataGridViewRequest;
        public MyControls.CustomComboBox comboBoxFilter;
    }
}