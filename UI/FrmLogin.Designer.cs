namespace Billing_System.UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            btnLogin = new Button();
            cmbUserType = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUserType = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblHeader = new Label();
            pboxClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cmbUserType);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUserType);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblHeader);
            panel1.Location = new Point(56, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 397);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 53);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbUserType
            // 
            cmbUserType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "User", "Admin" });
            cmbUserType.Location = new Point(40, 251);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(265, 31);
            cmbUserType.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(37, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(268, 30);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(37, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 30);
            txtUsername.TabIndex = 4;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserType.Location = new Point(37, 230);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(66, 17);
            lblUserType.TabIndex = 3;
            lblUserType.Text = "User Type";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(37, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(37, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(143, 23);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(83, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LOGIN";
            // 
            // pboxClose
            // 
            pboxClose.Image = (Image)resources.GetObject("pboxClose.Image");
            pboxClose.Location = new Point(436, 1);
            pboxClose.Name = "pboxClose";
            pboxClose.Size = new Size(40, 40);
            pboxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxClose.TabIndex = 1;
            pboxClose.TabStop = false;
            pboxClose.Click += pboxClose_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(488, 490);
            Controls.Add(pboxClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUserType;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblHeader;
        private Button btnLogin;
        private ComboBox cmbUserType;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pboxClose;
    }
}