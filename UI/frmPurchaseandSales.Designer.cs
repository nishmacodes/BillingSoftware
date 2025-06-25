namespace Billing_System.UI
{
    partial class frmPurchaseandSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseandSales));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            pnlDeaCust = new Panel();
            dtpBillDate = new DateTimePicker();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            lblBillDate = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            lblSearch = new Label();
            lblDeaCustTitle = new Label();
            pnlProductDetails = new Panel();
            btnAdd = new Button();
            txtQty = new TextBox();
            txtRate = new TextBox();
            txtInventory = new TextBox();
            txtProductName = new TextBox();
            txtProductSearch = new TextBox();
            lblRate = new Label();
            lblInventory = new Label();
            lblQty = new Label();
            lblProductName = new Label();
            lblProductSearch = new Label();
            lblProductTile = new Label();
            pnlDataGridview = new Panel();
            DGVAddedProducts = new DataGridView();
            lblDGVTitle = new Label();
            pnlCalculation = new Panel();
            btnSAVE = new Button();
            txtDiscount = new TextBox();
            txtReturnAmount = new TextBox();
            txtPaidAmount = new TextBox();
            txtGrandTotal = new TextBox();
            txtVAT = new TextBox();
            txtSubTotal = new TextBox();
            lblSubTotal = new Label();
            lblDiscount = new Label();
            lblVAT = new Label();
            lblGrandTotal = new Label();
            lblPaidAmount = new Label();
            lblReturnamount = new Label();
            lblCalculationTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            pnlDeaCust.SuspendLayout();
            pnlProductDetails.SuspendLayout();
            pnlDataGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAddedProducts).BeginInit();
            pnlCalculation.SuspendLayout();
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
            panel1.Size = new Size(1609, 38);
            panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1571, 6);
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
            lblTop.Location = new Point(795, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(186, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "PURCHASE AND SALES";
            // 
            // pnlDeaCust
            // 
            pnlDeaCust.Controls.Add(dtpBillDate);
            pnlDeaCust.Controls.Add(txtAddress);
            pnlDeaCust.Controls.Add(txtContact);
            pnlDeaCust.Controls.Add(txtEmail);
            pnlDeaCust.Controls.Add(txtName);
            pnlDeaCust.Controls.Add(txtSearch);
            pnlDeaCust.Controls.Add(lblBillDate);
            pnlDeaCust.Controls.Add(lblName);
            pnlDeaCust.Controls.Add(lblEmail);
            pnlDeaCust.Controls.Add(lblContact);
            pnlDeaCust.Controls.Add(lblAddress);
            pnlDeaCust.Controls.Add(lblSearch);
            pnlDeaCust.Controls.Add(lblDeaCustTitle);
            pnlDeaCust.Location = new Point(8, 53);
            pnlDeaCust.Name = "pnlDeaCust";
            pnlDeaCust.Size = new Size(1589, 125);
            pnlDeaCust.TabIndex = 3;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Location = new Point(1297, 32);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(250, 27);
            dtpBillDate.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(883, 32);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(299, 76);
            txtAddress.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(494, 78);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(273, 30);
            txtContact.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(494, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 30);
            txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(71, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 30);
            txtName.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(71, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 30);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillDate.ForeColor = Color.Black;
            lblBillDate.Location = new Point(1218, 34);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(73, 23);
            lblBillDate.TabIndex = 7;
            lblBillDate.Text = "Bill Date";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(4, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(416, 39);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(414, 80);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(70, 23);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(807, 34);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 23);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(4, 37);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            lblSearch.Click += label1_Click;
            // 
            // lblDeaCustTitle
            // 
            lblDeaCustTitle.AutoSize = true;
            lblDeaCustTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeaCustTitle.Location = new Point(4, 5);
            lblDeaCustTitle.Name = "lblDeaCustTitle";
            lblDeaCustTitle.Size = new Size(236, 23);
            lblDeaCustTitle.TabIndex = 0;
            lblDeaCustTitle.Text = "Dealer and customer Details";
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.Controls.Add(btnAdd);
            pnlProductDetails.Controls.Add(txtQty);
            pnlProductDetails.Controls.Add(txtRate);
            pnlProductDetails.Controls.Add(txtInventory);
            pnlProductDetails.Controls.Add(txtProductName);
            pnlProductDetails.Controls.Add(txtProductSearch);
            pnlProductDetails.Controls.Add(lblRate);
            pnlProductDetails.Controls.Add(lblInventory);
            pnlProductDetails.Controls.Add(lblQty);
            pnlProductDetails.Controls.Add(lblProductName);
            pnlProductDetails.Controls.Add(lblProductSearch);
            pnlProductDetails.Controls.Add(lblProductTile);
            pnlProductDetails.Location = new Point(7, 203);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(1590, 100);
            pnlProductDetails.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SpringGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1437, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 43);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(1189, 46);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(202, 30);
            txtQty.TabIndex = 23;
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRate.Location = new Point(915, 45);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(202, 30);
            txtRate.TabIndex = 22;
            // 
            // txtInventory
            // 
            txtInventory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInventory.Location = new Point(655, 45);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(191, 30);
            txtInventory.TabIndex = 21;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(337, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(215, 30);
            txtProductName.TabIndex = 20;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductSearch.Location = new Point(70, 44);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(199, 30);
            txtProductSearch.TabIndex = 19;
            txtProductSearch.TextChanged += txtProductSearch_TextChanged;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRate.ForeColor = Color.Black;
            lblRate.Location = new Point(865, 44);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(44, 23);
            lblRate.TabIndex = 18;
            lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventory.ForeColor = Color.Black;
            lblInventory.Location = new Point(567, 49);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(82, 23);
            lblInventory.TabIndex = 17;
            lblInventory.Text = "Inventory";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.Black;
            lblQty.Location = new Point(1142, 45);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(41, 23);
            lblQty.TabIndex = 16;
            lblQty.Text = "Qty.";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(275, 47);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(56, 23);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "Name";
            lblProductName.Click += label1_Click_1;
            // 
            // lblProductSearch
            // 
            lblProductSearch.AutoSize = true;
            lblProductSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductSearch.ForeColor = Color.Black;
            lblProductSearch.Location = new Point(5, 48);
            lblProductSearch.Name = "lblProductSearch";
            lblProductSearch.Size = new Size(61, 23);
            lblProductSearch.TabIndex = 15;
            lblProductSearch.Text = "Search";
            // 
            // lblProductTile
            // 
            lblProductTile.AutoSize = true;
            lblProductTile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductTile.Location = new Point(7, 11);
            lblProductTile.Name = "lblProductTile";
            lblProductTile.Size = new Size(133, 23);
            lblProductTile.TabIndex = 0;
            lblProductTile.Text = "Product Details";
            // 
            // pnlDataGridview
            // 
            pnlDataGridview.Controls.Add(DGVAddedProducts);
            pnlDataGridview.Controls.Add(lblDGVTitle);
            pnlDataGridview.Location = new Point(9, 312);
            pnlDataGridview.Name = "pnlDataGridview";
            pnlDataGridview.Size = new Size(810, 489);
            pnlDataGridview.TabIndex = 5;
            pnlDataGridview.Paint += pnlDataGridview_Paint;
            // 
            // DGVAddedProducts
            // 
            DGVAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAddedProducts.Location = new Point(5, 39);
            DGVAddedProducts.Name = "DGVAddedProducts";
            DGVAddedProducts.RowHeadersWidth = 51;
            DGVAddedProducts.Size = new Size(788, 423);
            DGVAddedProducts.TabIndex = 2;
            DGVAddedProducts.CellContentClick += DGVAddedProducts_CellContentClick;
            // 
            // lblDGVTitle
            // 
            lblDGVTitle.AutoSize = true;
            lblDGVTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDGVTitle.Location = new Point(5, 13);
            lblDGVTitle.Name = "lblDGVTitle";
            lblDGVTitle.Size = new Size(139, 23);
            lblDGVTitle.TabIndex = 1;
            lblDGVTitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            pnlCalculation.Controls.Add(btnSAVE);
            pnlCalculation.Controls.Add(txtDiscount);
            pnlCalculation.Controls.Add(txtReturnAmount);
            pnlCalculation.Controls.Add(txtPaidAmount);
            pnlCalculation.Controls.Add(txtGrandTotal);
            pnlCalculation.Controls.Add(txtVAT);
            pnlCalculation.Controls.Add(txtSubTotal);
            pnlCalculation.Controls.Add(lblSubTotal);
            pnlCalculation.Controls.Add(lblDiscount);
            pnlCalculation.Controls.Add(lblVAT);
            pnlCalculation.Controls.Add(lblGrandTotal);
            pnlCalculation.Controls.Add(lblPaidAmount);
            pnlCalculation.Controls.Add(lblReturnamount);
            pnlCalculation.Controls.Add(lblCalculationTitle);
            pnlCalculation.Location = new Point(839, 312);
            pnlCalculation.Name = "pnlCalculation";
            pnlCalculation.Size = new Size(758, 489);
            pnlCalculation.TabIndex = 6;
            // 
            // btnSAVE
            // 
            btnSAVE.BackColor = Color.Teal;
            btnSAVE.FlatStyle = FlatStyle.Flat;
            btnSAVE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSAVE.Location = new Point(295, 419);
            btnSAVE.Name = "btnSAVE";
            btnSAVE.Size = new Size(258, 43);
            btnSAVE.TabIndex = 26;
            btnSAVE.Text = "SAVE";
            btnSAVE.UseVisualStyleBackColor = false;
            btnSAVE.Click += button1_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(190, 123);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(496, 30);
            txtDiscount.TabIndex = 25;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtReturnAmount
            // 
            txtReturnAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReturnAmount.ForeColor = Color.DarkRed;
            txtReturnAmount.Location = new Point(190, 349);
            txtReturnAmount.Name = "txtReturnAmount";
            txtReturnAmount.ReadOnly = true;
            txtReturnAmount.Size = new Size(496, 47);
            txtReturnAmount.TabIndex = 24;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaidAmount.Location = new Point(190, 299);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(496, 30);
            txtPaidAmount.TabIndex = 23;
            txtPaidAmount.TextChanged += txtPaidAmount_TextChanged;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrandTotal.Location = new Point(190, 238);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(496, 30);
            txtGrandTotal.TabIndex = 22;
            // 
            // txtVAT
            // 
            txtVAT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVAT.Location = new Point(190, 183);
            txtVAT.Name = "txtVAT";
            txtVAT.Size = new Size(496, 30);
            txtVAT.TabIndex = 21;
            txtVAT.TextChanged += txtVAT_TextChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(190, 61);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(496, 30);
            txtSubTotal.TabIndex = 20;
            txtSubTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.ForeColor = Color.Black;
            lblSubTotal.Location = new Point(18, 64);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(80, 23);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Sub Total";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.ForeColor = Color.Black;
            lblDiscount.Location = new Point(18, 126);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(106, 23);
            lblDiscount.TabIndex = 10;
            lblDiscount.Text = "Discount (%)";
            // 
            // lblVAT
            // 
            lblVAT.AutoSize = true;
            lblVAT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVAT.ForeColor = Color.Black;
            lblVAT.Location = new Point(18, 190);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(68, 23);
            lblVAT.TabIndex = 9;
            lblVAT.Text = "VAT (%)";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.Black;
            lblGrandTotal.Location = new Point(18, 245);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(98, 23);
            lblGrandTotal.TabIndex = 8;
            lblGrandTotal.Text = "Grand Total";
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaidAmount.ForeColor = Color.Black;
            lblPaidAmount.Location = new Point(18, 302);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(109, 23);
            lblPaidAmount.TabIndex = 7;
            lblPaidAmount.Text = "Paid Amount";
            // 
            // lblReturnamount
            // 
            lblReturnamount.AutoSize = true;
            lblReturnamount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnamount.ForeColor = Color.Black;
            lblReturnamount.Location = new Point(18, 356);
            lblReturnamount.Name = "lblReturnamount";
            lblReturnamount.Size = new Size(128, 23);
            lblReturnamount.TabIndex = 6;
            lblReturnamount.Text = "Return Amount";
            // 
            // lblCalculationTitle
            // 
            lblCalculationTitle.AutoSize = true;
            lblCalculationTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculationTitle.Location = new Point(13, 11);
            lblCalculationTitle.Name = "lblCalculationTitle";
            lblCalculationTitle.Size = new Size(159, 23);
            lblCalculationTitle.TabIndex = 2;
            lblCalculationTitle.Text = "Calculation Details";
            // 
            // frmPurchaseandSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1609, 812);
            Controls.Add(pnlCalculation);
            Controls.Add(pnlDataGridview);
            Controls.Add(pnlProductDetails);
            Controls.Add(pnlDeaCust);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPurchaseandSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase and Sales";
            Load += frmPurchaseandSales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            pnlDeaCust.ResumeLayout(false);
            pnlDeaCust.PerformLayout();
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            pnlDataGridview.ResumeLayout(false);
            pnlDataGridview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAddedProducts).EndInit();
            pnlCalculation.ResumeLayout(false);
            pnlCalculation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private Panel pnlDeaCust;
        private Label lblSearch;
        private Label lblDeaCustTitle;
        private Label lblBillDate;
        private Label lblName;
        private Label lblEmail;
        private Label lblContact;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtSearch;
        private DateTimePicker dtpBillDate;
        private Panel pnlProductDetails;
        private Label lblProductSearch;
        private Label lblProductTile;
        private Label lblQty;
        private Label lblProductName;
        private Label lblRate;
        private Label lblInventory;
        private TextBox txtProductSearch;
        private TextBox txtQty;
        private TextBox txtRate;
        private TextBox txtInventory;
        private TextBox txtProductName;
        private Button btnAdd;
        private Panel pnlDataGridview;
        private Label lblDGVTitle;
        private DataGridView DGVAddedProducts;
        private Panel pnlCalculation;
        private Label lblCalculationTitle;
        private Label lblSubTotal;
        private Label lblDiscount;
        private Label lblVAT;
        private Label lblGrandTotal;
        private Label lblPaidAmount;
        private Label lblReturnamount;
        private TextBox txtDiscount;
        private TextBox txtReturnAmount;
        private TextBox txtPaidAmount;
        private TextBox txtGrandTotal;
        private TextBox txtVAT;
        private TextBox txtSubTotal;
        private Button btnSAVE;
    }
}