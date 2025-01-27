namespace ProvaiderEF
{
    partial class FormAuthorization
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
            lblAuthorization = new Label();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            panelBack = new Panel();
            btnAuthorization = new MyControls.CustomButton();
            textBoxPassword = new MyControls.CustomTextBox();
            textBoxLogin = new MyControls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panelBack.SuspendLayout();
            SuspendLayout();
            // 
            // lblAuthorization
            // 
            lblAuthorization.Anchor = AnchorStyles.Top;
            lblAuthorization.AutoSize = true;
            lblAuthorization.Font = new Font("Century Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthorization.ForeColor = Color.Gainsboro;
            lblAuthorization.Location = new Point(158, 135);
            lblAuthorization.Name = "lblAuthorization";
            lblAuthorization.Size = new Size(408, 63);
            lblAuthorization.TabIndex = 0;
            lblAuthorization.Text = "АВТОРИЗАЦИЯ";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.Location = new Point(554, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 32);
            btnMinimize.TabIndex = 7;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.Location = new Point(603, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(32, 32);
            btnMaximize.TabIndex = 6;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(651, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 5;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(btnAuthorization);
            panelBack.Controls.Add(textBoxPassword);
            panelBack.Controls.Add(textBoxLogin);
            panelBack.Dock = DockStyle.Fill;
            panelBack.Location = new Point(0, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(690, 730);
            panelBack.TabIndex = 8;
            panelBack.MouseDown += panelBack_MouseDown;
            // 
            // btnAuthorization
            // 
            btnAuthorization.Anchor = AnchorStyles.Top;
            btnAuthorization.BackColor = Color.FromArgb(119, 0, 255);
            btnAuthorization.BackgroundColor = Color.FromArgb(119, 0, 255);
            btnAuthorization.BorderColor = Color.FromArgb(128, 128, 255);
            btnAuthorization.BorderRadius = 10;
            btnAuthorization.BorderSize = 0;
            btnAuthorization.FlatAppearance.BorderSize = 0;
            btnAuthorization.FlatStyle = FlatStyle.Flat;
            btnAuthorization.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuthorization.ForeColor = Color.Gainsboro;
            btnAuthorization.Location = new Point(61, 486);
            btnAuthorization.Name = "btnAuthorization";
            btnAuthorization.Size = new Size(571, 60);
            btnAuthorization.TabIndex = 6;
            btnAuthorization.Text = "Войти";
            btnAuthorization.TextColor = Color.Gainsboro;
            btnAuthorization.UseVisualStyleBackColor = false;
            btnAuthorization.Click += btnAuthorization_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.BackColor = Color.FromArgb(26, 25, 62);
            textBoxPassword.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxPassword.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxPassword.BorderRadius = 10;
            textBoxPassword.BorderSize = 2;
            textBoxPassword.ForeColor = Color.Gainsboro;
            textBoxPassword.Location = new Point(61, 372);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(18, 12, 18, 12);
            textBoxPassword.PasswordChar = true;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "Введите ваш пароль";
            textBoxPassword.Size = new Size(571, 60);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UnderlinedStyle = false;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top;
            textBoxLogin.BackColor = Color.FromArgb(26, 25, 62);
            textBoxLogin.BorderColor = Color.FromArgb(26, 25, 62);
            textBoxLogin.BorderFocusColor = Color.FromArgb(119, 0, 255);
            textBoxLogin.BorderRadius = 10;
            textBoxLogin.BorderSize = 2;
            textBoxLogin.ForeColor = Color.Gainsboro;
            textBoxLogin.Location = new Point(61, 265);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Padding = new Padding(18, 12, 18, 12);
            textBoxLogin.PasswordChar = false;
            textBoxLogin.PlaceholderColor = Color.DarkGray;
            textBoxLogin.PlaceholderText = "Введите ваш логин";
            textBoxLogin.Size = new Size(571, 60);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.UnderlinedStyle = false;
            textBoxLogin.KeyDown += textBoxLogin_KeyDown;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 730);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnExit);
            Controls.Add(lblAuthorization);
            Controls.Add(panelBack);
            Name = "FormAuthorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += CustomForm_Load;
            KeyDown += FormAuthorization_KeyDown;
            Resize += CustomForm_Resize;
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panelBack.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthorization;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Panel panelBack;
        private MyControls.CustomTextBox textBoxLogin;
        private MyControls.CustomTextBox textBoxPassword;
        private MyControls.CustomButton btnAuthorization;
    }
}