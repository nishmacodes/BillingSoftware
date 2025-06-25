using Billing_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class FrmUserDashboard : Form
    {
        public FrmUserDashboard()
        {
            InitializeComponent();
        }
        //set a public static method to specify whether the form is purchase or sales

        public static string transactionType;

        private void FrmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();

        }

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = FrmLogin.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDealcust DeaCust = new FrmDealcust();
            DeaCust.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the value  on transactionType static method
            transactionType = "Purchase";
            frmPurchaseandSales purchase = new frmPurchaseandSales();
            purchase.Show();

        }

        private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the value  on transactionType static method
            transactionType = "Sales";
            frmPurchaseandSales sales = new frmPurchaseandSales();
            sales.Show();

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }
    }
}
