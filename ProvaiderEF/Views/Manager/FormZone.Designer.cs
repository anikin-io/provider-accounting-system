namespace ProvaiderEF
{
    partial class FormZone
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
            textBoxSearchAdress = new MyControls.CustomTextBox();
            btnSearch = new MyControls.CustomButton();
            lblResult = new Label();
            panelMap = new Panel();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panelSearch = new Panel();
            panelMap.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearchAdress
            // 
            textBoxSearchAdress.BackColor = Color.FromArgb(26, 25, 62);
            textBoxSearchAdress.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxSearchAdress.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxSearchAdress.BorderRadius = 30;
            textBoxSearchAdress.BorderSize = 2;
            textBoxSearchAdress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchAdress.ForeColor = Color.Gainsboro;
            textBoxSearchAdress.Location = new Point(17, 28);
            textBoxSearchAdress.Multiline = false;
            textBoxSearchAdress.Name = "textBoxSearchAdress";
            textBoxSearchAdress.Padding = new Padding(25, 12, 25, 12);
            textBoxSearchAdress.PasswordChar = false;
            textBoxSearchAdress.PlaceholderColor = Color.DarkGray;
            textBoxSearchAdress.PlaceholderText = "Введите адрес ";
            textBoxSearchAdress.Size = new Size(677, 57);
            textBoxSearchAdress.TabIndex = 4;
            textBoxSearchAdress.TextValue = "Введите адрес ";
            textBoxSearchAdress.UnderlinedStyle = false;
            textBoxSearchAdress.KeyDown += textBoxSearchAdress_KeyDown;
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
            btnSearch.Location = new Point(706, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 60);
            btnSearch.TabIndex = 3;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = Color.Gainsboro;
            lblResult.Location = new Point(40, 103);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMap
            // 
            panelMap.Controls.Add(gMapControl1);
            panelMap.Dock = DockStyle.Fill;
            panelMap.Location = new Point(0, 0);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(1542, 652);
            panelMap.TabIndex = 6;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(52, 12);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(693, 581);
            gMapControl1.TabIndex = 7;
            gMapControl1.Visible = false;
            gMapControl1.Zoom = 0D;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(textBoxSearchAdress);
            panelSearch.Controls.Add(lblResult);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Dock = DockStyle.Bottom;
            panelSearch.Location = new Point(0, 652);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1542, 245);
            panelSearch.TabIndex = 7;
            // 
            // FormZone
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 897);
            Controls.Add(panelMap);
            Controls.Add(panelSearch);
            Name = "FormZone";
            Text = "Зона покрытия";
            FormClosing += FormZone_FormClosing;
            panelMap.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MyControls.CustomTextBox textBoxSearchAdress;
        private MyControls.CustomButton btnSearch;
        private Label lblResult;
        private Panel panelMap;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panelSearch;
    }
}