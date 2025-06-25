using Billing_System.BLL;
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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void btnADD_Click(object sender, EventArgs e)
        {
            //getting data from UI
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate=decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //getting username of the logged in user
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;


            //Inserting Data Into Database

            bool success = pdal.Insert(p);
            //if the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //data inserted successfully
                MessageBox.Show("User Successfully created");
                clear();

            }
            else
            {
                //failed to insert data            
                MessageBox.Show("failed to add new user");
            }
            //refreshing data grid view
            DataTable dt = pdal.select();
            dgvProducts.DataSource = dt;
        }
        private void clear()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            cmbCategory.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";

        }
        categoriesDAL cdal = new categoriesDAL();
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dgvProducts.DataSource = dt;
           

            //creating datable to hold the categories from database
            DataTable categoriesDT=cdal.select();
            //specify datasource for category combobox
            cmbCategory.DataSource = categoriesDT;
            //specify display member and value member for combobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
            cmbCategory.SelectedIndex = -1;

        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of the particular row
            int rowIndex = e.RowIndex;
            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();


        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //get the values from user UI

            p.id = Convert.ToInt32(txtProductID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;
            //getting ID in added by field
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            p.added_by = usr.id;



            //Updating Data Into Database

            bool success = pdal.Update(p);
            //if the data is successfully Updated then the value of success will be true else it will be false
            if (success == true)
            {
                //data updated successfully
                MessageBox.Show("User Successfully updated");
                clear();

            }
            else
            {
                //failed to update data            
                MessageBox.Show("failed to update user");
            }
            //refreshing data grid view
            DataTable dt = pdal.select();
            dgvProducts.DataSource = dt;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            //getting userID from form
            p.id = int.Parse(txtProductID.Text);


            //delete data from Database

            bool success = pdal.Delete(p);

            //if the data  is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                //data deleted successfully
                MessageBox.Show("User Successfully deleted");
                clear();

            }
            else
            {
                //failed to delete data            
                MessageBox.Show("failed to delete user");
            }
            //refreshing data grid view
            DataTable dt = pdal.select();
            dgvProducts.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txtSearch.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                //show user based on keywords
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = pdal.select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
