namespace ProvaiderEF
{
    partial class FormMenuMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMaster));
            panelMenu = new Panel();
            btnExt = new FontAwesome.Sharp.IconButton();
            btnEquipment = new FontAwesome.Sharp.IconButton();
            btnTariff = new FontAwesome.Sharp.IconButton();
            btnRequest = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBoxLogo = new PictureBox();
            lblName = new Label();
            lblHello = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Purple;
            panelMenu.Controls.Add(btnExt);
            panelMenu.Controls.Add(btnEquipment);
            panelMenu.Controls.Add(btnTariff);
            panelMenu.Controls.Add(btnRequest);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(368, 1082);
            panelMenu.TabIndex = 1;
            // 
            // btnExt
            // 
            btnExt.Dock = DockStyle.Bottom;
            btnExt.FlatAppearance.BorderSize = 0;
            btnExt.FlatStyle = FlatStyle.Flat;
            btnExt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExt.ForeColor = Color.Gainsboro;
            btnExt.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btnExt.IconColor = Color.Gainsboro;
            btnExt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExt.IconSize = 32;
            btnExt.ImageAlign = ContentAlignment.MiddleLeft;
            btnExt.Location = new Point(0, 1002);
            btnExt.Name = "btnExt";
            btnExt.Padding = new Padding(10, 0, 20, 0);
            btnExt.Size = new Size(368, 80);
            btnExt.TabIndex = 7;
            btnExt.Text = "Выйти";
            btnExt.TextAlign = ContentAlignment.MiddleLeft;
            btnExt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExt_Click;
            // 
            // btnEquipment
            // 
            btnEquipment.Dock = DockStyle.Top;
            btnEquipment.FlatAppearance.BorderSize = 0;
            btnEquipment.FlatStyle = FlatStyle.Flat;
            btnEquipment.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquipment.ForeColor = Color.Gainsboro;
            btnEquipment.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            btnEquipment.IconColor = Color.Gainsboro;
            btnEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEquipment.IconSize = 32;
            btnEquipment.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquipment.Location = new Point(0, 260);
            btnEquipment.Name = "btnEquipment";
            btnEquipment.Padding = new Padding(10, 0, 20, 0);
            btnEquipment.Size = new Size(368, 60);
            btnEquipment.TabIndex = 4;
            btnEquipment.Text = "Оборудование";
            btnEquipment.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEquipment.UseVisualStyleBackColor = true;
            // 
            // btnTariff
            // 
            btnTariff.Dock = DockStyle.Top;
            btnTariff.FlatAppearance.BorderSize = 0;
            btnTariff.FlatStyle = FlatStyle.Flat;
            btnTariff.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTariff.ForeColor = Color.Gainsboro;
            btnTariff.IconChar = FontAwesome.Sharp.IconChar.Signal;
            btnTariff.IconColor = Color.Gainsboro;
            btnTariff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTariff.IconSize = 32;
            btnTariff.ImageAlign = ContentAlignment.MiddleLeft;
            btnTariff.Location = new Point(0, 200);
            btnTariff.Name = "btnTariff";
            btnTariff.Padding = new Padding(10, 0, 20, 0);
            btnTariff.Size = new Size(368, 60);
            btnTariff.TabIndex = 3;
            btnTariff.Text = "Тарифы";
            btnTariff.TextAlign = ContentAlignment.MiddleLeft;
            btnTariff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTariff.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            btnRequest.Dock = DockStyle.Top;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRequest.ForeColor = Color.Gainsboro;
            btnRequest.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnRequest.IconColor = Color.Gainsboro;
            btnRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRequest.IconSize = 32;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(0, 140);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(10, 0, 20, 0);
            btnRequest.Size = new Size(368, 60);
            btnRequest.TabIndex = 1;
            btnRequest.Text = "Заявки";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 140);
            panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(340, 109);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.DarkSlateBlue;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(368, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1860, 104);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.DarkSlateBlue;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.Location = new Point(1715, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 32);
            btnMinimize.TabIndex = 7;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.DarkSlateBlue;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.Location = new Point(1764, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(32, 32);
            btnMaximize.TabIndex = 6;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.DarkSlateBlue;
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(1812, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 5;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(57, 37);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(105, 30);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Главная";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.DarkSlateBlue;
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(22, 38);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(368, 104);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1860, 10);
            panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(pictureBoxLogo);
            panelDesktop.Controls.Add(lblName);
            panelDesktop.Controls.Add(lblHello);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(368, 114);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1860, 968);
            panelDesktop.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Bottom;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(778, 650);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(425, 274);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Gainsboro;
            lblName.Location = new Point(736, 446);
            lblName.Name = "lblName";
            lblName.Size = new Size(226, 78);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHello
            // 
            lblHello.Anchor = AnchorStyles.Top;
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHello.ForeColor = Color.Gainsboro;
            lblHello.Location = new Point(689, 358);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(676, 77);
            lblHello.TabIndex = 0;
            lblHello.Text = "Добро пожаловать,";
            lblHello.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenuMaster
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1082);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMenuMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuMaster";
            Load += CustomForm_Load;
            Resize += CustomForm_Resize;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnExt;
        private FontAwesome.Sharp.IconButton btnEquipment;
        private FontAwesome.Sharp.IconButton btnTariff;
        private FontAwesome.Sharp.IconButton btnRequest;
        private Panel panel1;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox btnMinimize1;
        private FontAwesome.Sharp.IconPictureBox btnMaximize1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBoxLogo;
        private Label lblName;
        private Label lblHello;
    }
}