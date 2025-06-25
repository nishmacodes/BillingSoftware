namespace Billing_System
{
    partial class FrmUserDashboard
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
            menuStripTop = new MenuStrip();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesFormsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            dealerAndCustomerToolStripMenuItem = new ToolStripMenuItem();
            lblLoggedInUser = new Label();
            lbluser = new Label();
            label1 = new Label();
            lblLName = new Label();
            lblAppFName = new Label();
            pnlfooter = new Panel();
            lblfooter = new Label();
            menuStripTop.SuspendLayout();
            pnlfooter.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.ImageScalingSize = new Size(20, 20);
            menuStripTop.Items.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, salesFormsToolStripMenuItem, inventoryToolStripMenuItem, dealerAndCustomerToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Size = new Size(1273, 28);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(81, 24);
            purchaseToolStripMenuItem.Text = "Purchase";
            purchaseToolStripMenuItem.Click += purchaseToolStripMenuItem_Click;
            // 
            // salesFormsToolStripMenuItem
            // 
            salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            salesFormsToolStripMenuItem.Size = new Size(61, 24);
            salesFormsToolStripMenuItem.Text = "Sales ";
            salesFormsToolStripMenuItem.Click += salesFormsToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(84, 24);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            dealerAndCustomerToolStripMenuItem.Size = new Size(163, 24);
            dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            dealerAndCustomerToolStripMenuItem.Click += dealerAndCustomerToolStripMenuItem_Click;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = Color.LimeGreen;
            lblLoggedInUser.Location = new Point(66, 45);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(0, 23);
            lblLoggedInUser.TabIndex = 5;
            lblLoggedInUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluser.Location = new Point(12, 45);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(48, 23);
            lbluser.TabIndex = 4;
            lbluser.Text = "User:";
            lbluser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(732, 312);
            label1.Name = "label1";
            label1.Size = new Size(374, 31);
            label1.TabIndex = 9;
            label1.Text = "Billing and Inventory Management";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(896, 266);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(117, 46);
            lblLName.TabIndex = 8;
            lblLName.Text = "STORE";
            // 
            // lblAppFName
            // 
            lblAppFName.AutoSize = true;
            lblAppFName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFName.Location = new Point(815, 266);
            lblAppFName.Name = "lblAppFName";
            lblAppFName.Size = new Size(86, 46);
            lblAppFName.TabIndex = 7;
            lblAppFName.Text = "ANY";
            // 
            // pnlfooter
            // 
            pnlfooter.BackColor = Color.Teal;
            pnlfooter.Controls.Add(lblfooter);
            pnlfooter.Dock = DockStyle.Bottom;
            pnlfooter.Location = new Point(0, 407);
            pnlfooter.Name = "pnlfooter";
            pnlfooter.Size = new Size(1273, 43);
            pnlfooter.TabIndex = 10;
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
            // FrmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 450);
            Controls.Add(pnlfooter);
            Controls.Add(label1);
            Controls.Add(lblLName);
            Controls.Add(lblAppFName);
            Controls.Add(lblLoggedInUser);
            Controls.Add(lbluser);
            Controls.Add(menuStripTop);
            MainMenuStrip = menuStripTop;
            Name = "FrmUserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmUserDashboard_FormClosed;
            Load += FrmUserDashboard_Load;
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            pnlfooter.ResumeLayout(false);
            pnlfooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesFormsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label lblLoggedInUser;
        private Label lbluser;
        private Label label1;
        private Label lblLName;
        private Label lblAppFName;
        private Panel pnlfooter;
        private Label lblfooter;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}