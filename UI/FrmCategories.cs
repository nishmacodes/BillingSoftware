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
using static System.Net.Mime.MediaTypeNames;

namespace Billing_System.UI
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void btnADD_Click(object sender, EventArgs e)
        {
            //getting data from UI
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //getting username of the logged in user
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;


            //Inserting Data Into Database

            bool success = dal.Insert(c);
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
            DataTable dt = dal.select();
            dgvCategories.DataSource = dt;

        }
        private void clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";

        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of the particular row
            int rowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //get the values from user UI

            c.id = Convert.ToInt32(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;
            //getting ID in added by field
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            c.added_by = usr.id;



            //Updating Data Into Database

            bool success = dal.Update(c);
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
            DataTable dt = dal.select();
            dgvCategories.DataSource = dt;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            //getting userID from form
            c.id = int.Parse(txtCategoryID.Text);


            //delete data from Database

            bool success = dal.Delete(c);

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
            DataTable dt = dal.select();
            dgvCategories.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txtSearch.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                //show user based on keywords
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
