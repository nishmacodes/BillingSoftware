namespace Billing_System.UI
{
    partial class FrmDealcust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDealcust));
            cmbType = new ComboBox();
            lblType = new Label();
            lblName = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvDeaCust = new DataGridView();
            btnDELETE = new Button();
            btnUPDATE = new Button();
            btnADD = new Button();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtDeaCustID = new TextBox();
            lblAddress = new Label();
            lblDeaCustID = new Label();
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Dealer", "Customer", "" });
            cmbType.Location = new Point(171, 105);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(278, 28);
            cmbType.TabIndex = 45;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(16, 108);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 23);
            lblType.TabIndex = 44;
            lblType.Text = "Type";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(17, 163);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 41;
            lblName.Text = "Name";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(582, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(371, 30);
            txtSearch.TabIndex = 40;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(517, 58);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 39;
            lblSearch.Text = "Search";
            // 
            // dgvDeaCust
            // 
            dgvDeaCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeaCust.Location = new Point(517, 105);
            dgvDeaCust.Name = "dgvDeaCust";
            dgvDeaCust.RowHeadersWidth = 51;
            dgvDeaCust.Size = new Size(436, 367);
            dgvDeaCust.TabIndex = 38;
            dgvDeaCust.RowHeaderMouseClick += dgvDeaCust_RowHeaderMouseClick;
            // 
            // btnDELETE
            // 
            btnDELETE.BackColor = Color.DarkRed;
            btnDELETE.FlatStyle = FlatStyle.Flat;
            btnDELETE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDELETE.ForeColor = Color.White;
            btnDELETE.Location = new Point(595, 495);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(116, 57);
            btnDELETE.TabIndex = 37;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = false;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.BackColor = Color.Chartreuse;
            btnUPDATE.FlatStyle = FlatStyle.Flat;
            btnUPDATE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUPDATE.Location = new Point(466, 495);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(112, 55);
            btnUPDATE.TabIndex = 36;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = false;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.ForestGreen;
            btnADD.FlatStyle = FlatStyle.Flat;
            btnADD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADD.Location = new Point(322, 495);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(125, 56);
            btnADD.TabIndex = 35;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnADD_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(171, 318);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(279, 154);
            txtAddress.TabIndex = 34;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(171, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 30);
            txtName.TabIndex = 33;
            // 
            // txtDeaCustID
            // 
            txtDeaCustID.BorderStyle = BorderStyle.FixedSingle;
            txtDeaCustID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeaCustID.Location = new Point(171, 59);
            txtDeaCustID.Name = "txtDeaCustID";
            txtDeaCustID.ReadOnly = true;
            txtDeaCustID.Size = new Size(279, 30);
            txtDeaCustID.TabIndex = 32;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(16, 322);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 31;
            lblAddress.Text = "Address";
            // 
            // lblDeaCustID
            // 
            lblDeaCustID.AutoSize = true;
            lblDeaCustID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeaCustID.Location = new Point(16, 58);
            lblDeaCustID.Name = "lblDeaCustID";
            lblDeaCustID.Size = new Size(96, 23);
            lblDeaCustID.TabIndex = 30;
            lblDeaCustID.Text = "DeaCust ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(lblTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 38);
            panel1.TabIndex = 29;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(927, 6);
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
            lblTop.Location = new Point(399, 6);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(195, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "DEALER and CUSTOMER";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(17, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 47;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(171, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 30);
            txtEmail.TabIndex = 46;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.Location = new Point(18, 264);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 23);
            lblContact.TabIndex = 49;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(171, 257);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(279, 30);
            txtContact.TabIndex = 48;
            // 
            // FrmDealcust
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 582);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDeaCust);
            Controls.Add(btnDELETE);
            Controls.Add(btnUPDATE);
            Controls.Add(btnADD);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtDeaCustID);
            Controls.Add(lblAddress);
            Controls.Add(lblDeaCustID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDealcust";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDealcust";
            ((System.ComponentModel.ISupportInitialize)dgvDeaCust).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private Label lblType;
        private Label lblName;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvDeaCust;
        private Button btnDELETE;
        private Button btnUPDATE;
        private Button btnADD;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtDeaCustID;
        private Label lblAddress;
        private Label lblDeaCustID;
        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
    }
}