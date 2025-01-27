namespace ProvaiderEF
{
    partial class FormRequestMaster
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
            comboBoxFilter = new MyControls.CustomComboBox();
            btnFinish = new MyControls.CustomButton();
            textBoxSearch = new MyControls.CustomTextBox();
            btnSearch = new MyControls.CustomButton();
            dataGridViewRequest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).BeginInit();
            SuspendLayout();
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
            comboBoxFilter.TabIndex = 22;
            comboBoxFilter.Texts = "";
            comboBoxFilter.OnSelectedIndexChanged += comboBoxFilter_OnSelectedIndexChanged;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinish.BackColor = Color.FromArgb(119, 0, 255);
            btnFinish.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnFinish.BorderColor = Color.FromArgb(128, 128, 255);
            btnFinish.BorderRadius = 30;
            btnFinish.BorderSize = 0;
            btnFinish.FlatAppearance.BorderSize = 0;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.ForeColor = Color.Gainsboro;
            btnFinish.Location = new Point(1622, 38);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(183, 60);
            btnFinish.TabIndex = 21;
            btnFinish.Text = "Завершить";
            btnFinish.TextColor = Color.Gainsboro;
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
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
            textBoxSearch.TabIndex = 18;
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
            btnSearch.TabIndex = 17;
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 25, 62);
            dataGridViewRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequest.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridViewRequest.BorderStyle = BorderStyle.None;
            dataGridViewRequest.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewRequest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRequest.ColumnHeadersHeight = 60;
            dataGridViewRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(58, 56, 126);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewRequest.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRequest.EnableHeadersVisualStyles = false;
            dataGridViewRequest.Location = new Point(30, 144);
            dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewRequest.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRequest.RowHeadersVisible = false;
            dataGridViewRequest.RowHeadersWidth = 82;
            dataGridViewRequest.RowTemplate.Height = 60;
            dataGridViewRequest.ScrollBars = ScrollBars.Vertical;
            dataGridViewRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequest.Size = new Size(1775, 715);
            dataGridViewRequest.TabIndex = 16;
            dataGridViewRequest.CellFormatting += dataGridViewRequest_CellFormatting;
            // 
            // FormRequestMaster
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1834, 897);
            Controls.Add(comboBoxFilter);
            Controls.Add(btnFinish);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewRequest);
            Name = "FormRequestMaster";
            Text = "Заявки";
            Load += FormRequestMaster_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public MyControls.CustomComboBox comboBoxFilter;
        private MyControls.CustomButton btnFinish;
        private MyControls.CustomTextBox textBoxSearch;
        private MyControls.CustomButton btnSearch;
        private DataGridView dataGridViewRequest;
    }
}