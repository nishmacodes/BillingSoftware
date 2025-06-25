namespace Billing_System.UI
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            dgvTransactions = new DataGridView();
            lblTransactionType = new Label();
            cmbTransactionType = new ComboBox();
            btnShowall = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
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
            panel1.Size = new Size(1196, 38);
            panel1.TabIndex = 2;
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
            lblTop.Size = new Size(133, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "TRANSACTIONS";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 142);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(1172, 409);
            dgvTransactions.TabIndex = 3;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionType.Location = new Point(12, 80);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(137, 23);
            lblTransactionType.TabIndex = 4;
            lblTransactionType.Text = "Transaction Type";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "Purchase", "Sales", "" });
            cmbTransactionType.Location = new Point(155, 77);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(392, 31);
            cmbTransactionType.TabIndex = 5;
            cmbTransactionType.SelectedIndexChanged += cmbTransactionType_SelectedIndexChanged;
            // 
            // btnShowall
            // 
            btnShowall.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowall.Location = new Point(804, 69);
            btnShowall.Name = "btnShowall";
            btnShowall.Size = new Size(191, 44);
            btnShowall.TabIndex = 6;
            btnShowall.Text = "Show All";
            btnShowall.UseVisualStyleBackColor = true;
            btnShowall.Click += btnShowall_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1196, 563);
            Controls.Add(btnShowall);
            Controls.Add(cmbTransactionType);
            Controls.Add(lblTransactionType);
            Controls.Add(dgvTransactions);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            Load += frmTransactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private DataGridView dgvTransactions;
        private Label lblTransactionType;
        private ComboBox cmbTransactionType;
        private Button btnShowall;
    }
}