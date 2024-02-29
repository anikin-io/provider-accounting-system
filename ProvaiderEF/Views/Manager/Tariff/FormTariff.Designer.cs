namespace ProvaiderEF
{
    partial class FormTariff
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tariffBindingSource = new BindingSource(components);
            dataGridViewTariff = new DataGridView();
            tariffIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tariffNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            speedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tariffCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tariffDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnSearch = new MyControls.CustomButton();
            textBoxSearch = new MyControls.CustomTextBox();
            btnInsert = new MyControls.CustomButton();
            btnUpdate = new MyControls.CustomButton();
            btnDelete = new MyControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)tariffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTariff).BeginInit();
            SuspendLayout();
            // 
            // tariffBindingSource
            // 
            tariffBindingSource.DataSource = typeof(Tariff);
            // 
            // dataGridViewTariff
            // 
            dataGridViewTariff.AllowUserToAddRows = false;
            dataGridViewTariff.AllowUserToDeleteRows = false;
            dataGridViewTariff.AllowUserToOrderColumns = true;
            dataGridViewTariff.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 25, 62);
            dataGridViewTariff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTariff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTariff.AutoGenerateColumns = false;
            dataGridViewTariff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTariff.BackgroundColor = Color.FromArgb(34, 33, 74);
            dataGridViewTariff.BorderStyle = BorderStyle.None;
            dataGridViewTariff.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewTariff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(119, 0, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewTariff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTariff.ColumnHeadersHeight = 60;
            dataGridViewTariff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTariff.Columns.AddRange(new DataGridViewColumn[] { tariffIdDataGridViewTextBoxColumn, tariffNameDataGridViewTextBoxColumn, speedDataGridViewTextBoxColumn, tariffCostDataGridViewTextBoxColumn, tariffDescriptionDataGridViewTextBoxColumn, paymentTypeDataGridViewTextBoxColumn });
            dataGridViewTariff.DataSource = tariffBindingSource;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(31, 30, 68);
            dataGridViewCellStyle13.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(58, 56, 126);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridViewTariff.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTariff.EnableHeadersVisualStyles = false;
            dataGridViewTariff.Location = new Point(27, 149);
            dataGridViewTariff.Name = "dataGridViewTariff";
            dataGridViewTariff.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewTariff.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTariff.RowHeadersVisible = false;
            dataGridViewTariff.RowHeadersWidth = 82;
            dataGridViewTariff.RowTemplate.Height = 60;
            dataGridViewTariff.ScrollBars = ScrollBars.Vertical;
            dataGridViewTariff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTariff.Size = new Size(1483, 715);
            dataGridViewTariff.TabIndex = 0;
            // 
            // tariffIdDataGridViewTextBoxColumn
            // 
            tariffIdDataGridViewTextBoxColumn.DataPropertyName = "TariffId";
            tariffIdDataGridViewTextBoxColumn.HeaderText = "ID";
            tariffIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            tariffIdDataGridViewTextBoxColumn.Name = "tariffIdDataGridViewTextBoxColumn";
            tariffIdDataGridViewTextBoxColumn.ReadOnly = true;
            tariffIdDataGridViewTextBoxColumn.Width = 79;
            // 
            // tariffNameDataGridViewTextBoxColumn
            // 
            tariffNameDataGridViewTextBoxColumn.DataPropertyName = "TariffName";
            dataGridViewCellStyle10.ForeColor = Color.MediumAquamarine;
            tariffNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            tariffNameDataGridViewTextBoxColumn.HeaderText = "Название";
            tariffNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            tariffNameDataGridViewTextBoxColumn.Name = "tariffNameDataGridViewTextBoxColumn";
            tariffNameDataGridViewTextBoxColumn.ReadOnly = true;
            tariffNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            speedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            speedDataGridViewTextBoxColumn.HeaderText = "Скорость";
            speedDataGridViewTextBoxColumn.MinimumWidth = 10;
            speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            speedDataGridViewTextBoxColumn.ReadOnly = true;
            speedDataGridViewTextBoxColumn.Width = 173;
            // 
            // tariffCostDataGridViewTextBoxColumn
            // 
            tariffCostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tariffCostDataGridViewTextBoxColumn.DataPropertyName = "TariffCost";
            dataGridViewCellStyle12.Format = "C0";
            dataGridViewCellStyle12.NullValue = "0";
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            tariffCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            tariffCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            tariffCostDataGridViewTextBoxColumn.MinimumWidth = 10;
            tariffCostDataGridViewTextBoxColumn.Name = "tariffCostDataGridViewTextBoxColumn";
            tariffCostDataGridViewTextBoxColumn.ReadOnly = true;
            tariffCostDataGridViewTextBoxColumn.Width = 247;
            // 
            // tariffDescriptionDataGridViewTextBoxColumn
            // 
            tariffDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tariffDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TariffDescription";
            tariffDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            tariffDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            tariffDescriptionDataGridViewTextBoxColumn.Name = "tariffDescriptionDataGridViewTextBoxColumn";
            tariffDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            paymentTypeDataGridViewTextBoxColumn.HeaderText = "Тип оплаты";
            paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            paymentTypeDataGridViewTextBoxColumn.Width = 174;
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
            btnSearch.Location = new Point(603, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 60);
            btnSearch.TabIndex = 1;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            textBoxSearch.Location = new Point(27, 44);
            textBoxSearch.Multiline = false;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Padding = new Padding(25, 12, 25, 12);
            textBoxSearch.PasswordChar = false;
            textBoxSearch.PlaceholderColor = Color.DarkGray;
            textBoxSearch.PlaceholderText = "Введите поисковый запрос";
            textBoxSearch.Size = new Size(564, 60);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextValue = "Введите поисковый запрос";
            textBoxSearch.UnderlinedStyle = false;
            textBoxSearch._TextChanged += textBoxSearch__TextChanged;
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
            btnInsert.Location = new Point(978, 44);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(168, 60);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Добавить";
            btnInsert.TextColor = Color.Gainsboro;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
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
            btnUpdate.Location = new Point(1165, 43);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 60);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Обновить";
            btnUpdate.TextColor = Color.Gainsboro;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnDelete.Location = new Point(1350, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 60);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.TextColor = Color.Gainsboro;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormTariff
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 897);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewTariff);
            Name = "FormTariff";
            Text = "Тарифы";
            ((System.ComponentModel.ISupportInitialize)tariffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTariff).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource tariffBindingSource;
        private DataGridView dataGridViewTariff;
        private DataGridViewTextBoxColumn tariffIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tariffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tariffCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tariffDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private MyControls.CustomButton btnSearch;
        private MyControls.CustomTextBox textBoxSearch;
        private MyControls.CustomButton btnInsert;
        private MyControls.CustomButton btnUpdate;
        private MyControls.CustomButton btnDelete;
    }
}