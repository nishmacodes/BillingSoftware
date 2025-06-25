namespace Billing_System.UI
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblFirstName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            lblLastName = new Label();
            lblUserName = new Label();
            lblGender = new Label();
            lblContact = new Label();
            txtContact = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUserType = new Label();
            cmbGender = new ComboBox();
            cmbUserType = new ComboBox();
            txtUserID = new TextBox();
            lblUserID = new Label();
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtFirstName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(lblTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 38);
            panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1069, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(26, 29);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop.Location = new Point(459, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(59, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "USERS";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(10, 130);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(135, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 30);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(11, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(134, 177);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(196, 30);
            txtLastName.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(135, 281);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(196, 30);
            txtUserName.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(10, 179);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 23);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(10, 283);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 23);
            lblUserName.TabIndex = 13;
            lblUserName.Text = "User Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(11, 535);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(66, 23);
            lblGender.TabIndex = 21;
            lblGender.Text = "Gender";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(11, 382);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 23);
            lblContact.TabIndex = 19;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(135, 380);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(196, 30);
            txtContact.TabIndex = 18;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(12, 431);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 17;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(136, 429);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(196, 82);
            txtAddress.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(136, 333);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(196, 30);
            txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(11, 333);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserType.Location = new Point(12, 588);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(84, 23);
            lblUserType.TabIndex = 25;
            lblUserType.Text = "User Type";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Not Specified", "" });
            cmbGender.Location = new Point(137, 534);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(193, 31);
            cmbGender.TabIndex = 28;
            // 
            // cmbUserType
            // 
            cmbUserType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "User", "Admin" });
            cmbUserType.Location = new Point(137, 585);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(193, 31);
            cmbUserType.TabIndex = 29;
            // 
            // txtUserID
            // 
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(137, 79);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(196, 30);
            txtUserID.TabIndex = 31;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(12, 79);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(66, 23);
            lblUserID.TabIndex = 30;
            lblUserID.Text = "User ID";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(417, 124);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(631, 487);
            dgvUsers.TabIndex = 32;
            dgvUsers.RowHeaderMouseClick += dgvUsers_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(546, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(502, 30);
            txtSearch.TabIndex = 34;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(421, 77);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 33;
            lblSearch.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(191, 648);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(209, 48);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Chartreuse;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(432, 648);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 48);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(678, 648);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(232, 48);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_2;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(136, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(196, 30);
            txtFirstName.TabIndex = 38;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1098, 766);
            Controls.Add(txtFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUsers);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(cmbUserType);
            Controls.Add(cmbGender);
            Controls.Add(lblUserType);
            Controls.Add(lblGender);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblFirstName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += FrmUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTop;
        private PictureBox pictureBoxClose;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private Label lblLastName;
        private Label lblUserName;
        private Label lblGender;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUserType;
        private ComboBox cmbGender;
        private ComboBox cmbUserType;
        private TextBox txtUserID;
        private Label lblUserID;
        private DataGridView dgvUsers;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtFirstName;
    }
}