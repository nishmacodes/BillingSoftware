namespace Billing_System.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            dgvProducts = new DataGridView();
            lblCategory = new Label();
            cmbCategories = new ComboBox();
            btnALL = new Button();
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
            panel1.Size = new Size(1198, 38);
            panel1.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1167, 3);
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
            lblTop.Location = new Point(573, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(101, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "INVENTORY";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 130);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1174, 506);
            dgvProducts.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(18, 78);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // cmbCategories
            // 
            cmbCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(103, 75);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(401, 31);
            cmbCategories.TabIndex = 6;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // btnALL
            // 
            btnALL.FlatStyle = FlatStyle.Flat;
            btnALL.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnALL.Location = new Point(593, 65);
            btnALL.Name = "btnALL";
            btnALL.Size = new Size(202, 45);
            btnALL.TabIndex = 7;
            btnALL.Text = "SHOW ALL";
            btnALL.UseVisualStyleBackColor = true;
            btnALL.Click += btnALL_Click;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1198, 648);
            Controls.Add(btnALL);
            Controls.Add(cmbCategories);
            Controls.Add(lblCategory);
            Controls.Add(dgvProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventory";
            Load += frmInventory_Load;
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
        private DataGridView dgvProducts;
        private Label lblCategory;
        private ComboBox cmbCategories;
        private Button btnALL;
    }
}