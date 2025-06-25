namespace Billing_System
{
    partial class FrmAdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlfooter = new Panel();
            lblfooter = new Label();
            menuStrip1 = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            dealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            lbluser = new Label();
            lblLoggedInUser = new Label();
            lblAppFName = new Label();
            lblLName = new Label();
            label1 = new Label();
            pnlfooter.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlfooter
            // 
            pnlfooter.BackColor = Color.Teal;
            pnlfooter.Controls.Add(lblfooter);
            pnlfooter.Dock = DockStyle.Bottom;
            pnlfooter.Location = new Point(0, 512);
            pnlfooter.Name = "pnlfooter";
            pnlfooter.Size = new Size(1207, 43);
            pnlfooter.TabIndex = 0;
            // 
            // lblfooter
            // 
            lblfooter.AutoSize = true;
            lblfooter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfooter.ForeColor = Color.White;
            lblfooter.Location = new Point(896, 11);
            lblfooter.Name = "lblfooter";
            lblfooter.Size = new Size(181, 23);
            lblfooter.TabIndex = 0;
            lblfooter.Text = "Developed By: Nishma";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem, dealerAndCustomerToolStripMenuItem, inventoryToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1207, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStriptop";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            dealerAndCustomerToolStripMenuItem.Size = new Size(163, 24);
            dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            dealerAndCustomerToolStripMenuItem.Click += dealerAndCustomerToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(84, 24);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(104, 24);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluser.Location = new Point(12, 37);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(48, 23);
            lbluser.TabIndex = 2;
            lbluser.Text = "User:";
            lbluser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = Color.LimeGreen;
            lblLoggedInUser.Location = new Point(66, 37);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(0, 23);
            lblLoggedInUser.TabIndex = 3;
            lblLoggedInUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppFName
            // 
            lblAppFName.AutoSize = true;
            lblAppFName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFName.Location = new Point(774, 368);
            lblAppFName.Name = "lblAppFName";
            lblAppFName.Size = new Size(86, 46);
            lblAppFName.TabIndex = 4;
            lblAppFName.Text = "ANY";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(855, 368);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(117, 46);
            lblLName.TabIndex = 5;
            lblLName.Text = "STORE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(691, 414);
            label1.Name = "label1";
            label1.Size = new Size(374, 31);
            label1.TabIndex = 6;
            label1.Text = "Billing and Inventory Management";
            // 
            // FrmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 555);
            Controls.Add(label1);
            Controls.Add(lblLName);
            Controls.Add(lblAppFName);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lbluser);
            Controls.Add(pnlfooter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmAdminDashboard_FormClosed;
            Load += FrmAdminDashboard_Load;
            pnlfooter.ResumeLayout(false);
            pnlfooter.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlfooter;
        private Label lblfooter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private Label lbluser;
        private Label lblLoggedInUser;
        private Label lblAppFName;
        private Label lblLName;
        private Label label1;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}
