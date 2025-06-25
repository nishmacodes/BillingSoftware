using Billing_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //display the categories in combobox
            DataTable cDt = cdal.select();
            cmbCategories.DataSource = cDt;

            //give the value member and display member for combobox
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            //display all the products in datagridview when form loaded

            DataTable pDt = pdal.select();
            dgvProducts.DataSource = pDt;

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display all the products based on selected category

            string category = cmbCategories.Text;
            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvProducts.DataSource = dt;
        }

        private void btnALL_Click(object sender, EventArgs e)
        {
            //display all the products when button clicked
            DataTable dt=pdal.select();
            dgvProducts.DataSource=dt;
        }
    }
}
