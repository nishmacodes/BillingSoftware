namespace Billing_System.UI
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblSearch = new Label();
            dgvProducts = new DataGridView();
            btnDELETE = new Button();
            btnUPDATE = new Button();
            btnADD = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtProductID = new TextBox();
            lblDescription = new Label();
            lblProductID = new Label();
            txtSearch = new TextBox();
            lblName = new Label();
            lblRate = new Label();
            txtRate = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
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
            panel1.Size = new Size(956, 38);
            panel1.TabIndex = 2;
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
            lblTop.Size = new Size(96, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "PRODUCTS";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(508, 47);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 22;
            lblSearch.Text = "Search";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(508, 94);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(436, 311);
            dgvProducts.TabIndex = 21;
            dgvProducts.RowHeaderMouseClick += dgvProducts_RowHeaderMouseClick;
            // 
            // btnDELETE
            // 
            btnDELETE.BackColor = Color.DarkRed;
            btnDELETE.FlatStyle = FlatStyle.Flat;
            btnDELETE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDELETE.ForeColor = Color.White;
            btnDELETE.Location = new Point(586, 441);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(116, 57);
            btnDELETE.TabIndex = 20;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = false;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.BackColor = Color.Chartreuse;
            btnUPDATE.FlatStyle = FlatStyle.Flat;
            btnUPDATE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUPDATE.Location = new Point(457, 441);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(112, 55);
            btnUPDATE.TabIndex = 19;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = false;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.ForestGreen;
            btnADD.FlatStyle = FlatStyle.Flat;
            btnADD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADD.Location = new Point(313, 441);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(125, 56);
            btnADD.TabIndex = 18;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnADD_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(162, 199);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(279, 154);
            txtDescription.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(162, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 30);
            txtName.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.BorderStyle = BorderStyle.FixedSingle;
            txtProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(162, 48);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(279, 30);
            txtProductID.TabIndex = 15;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(7, 203);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductID.Location = new Point(7, 47);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(92, 23);
            lblProductID.TabIndex = 13;
            lblProductID.Text = "Product ID";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(573, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(371, 30);
            txtSearch.TabIndex = 23;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 24;
            lblName.Text = "Name";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRate.Location = new Point(12, 382);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(44, 23);
            lblRate.TabIndex = 26;
            lblRate.Text = "Rate";
            // 
            // txtRate
            // 
            txtRate.BorderStyle = BorderStyle.FixedSingle;
            txtRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRate.Location = new Point(162, 375);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(279, 30);
            txtRate.TabIndex = 25;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(12, 149);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(163, 146);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(278, 28);
            cmbCategory.TabIndex = 28;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 520);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblRate);
            Controls.Add(txtRate);
            Controls.Add(lblName);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvProducts);
            Controls.Add(btnDELETE);
            Controls.Add(btnUPDATE);
            Controls.Add(btnADD);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtProductID);
            Controls.Add(lblDescription);
            Controls.Add(lblProductID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private Label lblSearch;
        private DataGridView dgvProducts;
        private Button btnDELETE;
        private Button btnUPDATE;
        private Button btnADD;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtProductID;
        private Label lblDescription;
        private Label lblProductID;
        private TextBox txtSearch;
        private Label lblName;
        private Label lblRate;
        private TextBox txtRate;
        private Label lblCategory;
        private ComboBox cmbCategory;
    }
}