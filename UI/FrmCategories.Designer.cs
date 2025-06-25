namespace Billing_System.UI
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            lblTop = new Label();
            lblCategoryID = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            txtCategoryID = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            btnADD = new Button();
            btnUPDATE = new Button();
            btnDELETE = new Button();
            dgvCategories = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
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
            panel1.Size = new Size(922, 38);
            panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(893, 3);
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
            lblTop.Location = new Point(394, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(107, 23);
            lblTop.TabIndex = 0;
            lblTop.Text = "CATEGORIES";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryID.Location = new Point(28, 74);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(101, 23);
            lblCategoryID.TabIndex = 2;
            lblCategoryID.Text = "Category ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(28, 125);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 23);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(28, 173);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryID.Location = new Point(183, 75);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(279, 30);
            txtCategoryID.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(183, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(279, 30);
            txtTitle.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(183, 169);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(279, 154);
            txtDescription.TabIndex = 7;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.ForestGreen;
            btnADD.FlatStyle = FlatStyle.Flat;
            btnADD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADD.Location = new Point(250, 373);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(125, 56);
            btnADD.TabIndex = 8;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnADD_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.BackColor = Color.Chartreuse;
            btnUPDATE.FlatStyle = FlatStyle.Flat;
            btnUPDATE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUPDATE.Location = new Point(394, 373);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(112, 55);
            btnUPDATE.TabIndex = 9;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = false;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.BackColor = Color.DarkRed;
            btnDELETE.FlatStyle = FlatStyle.Flat;
            btnDELETE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDELETE.ForeColor = Color.White;
            btnDELETE.Location = new Point(523, 373);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(116, 57);
            btnDELETE.TabIndex = 10;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = false;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(529, 121);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(379, 198);
            dgvCategories.TabIndex = 11;
            dgvCategories.RowHeaderMouseClick += dgvCategories_RowHeaderMouseClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(529, 74);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(596, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(309, 30);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(922, 474);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvCategories);
            Controls.Add(btnDELETE);
            Controls.Add(btnUPDATE);
            Controls.Add(btnADD);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtCategoryID);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblCategoryID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategories";
            Load += FrmCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label lblTop;
        private Label lblCategoryID;
        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtCategoryID;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button btnADD;
        private Button btnUPDATE;
        private Button btnDELETE;
        private DataGridView dgvCategories;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}