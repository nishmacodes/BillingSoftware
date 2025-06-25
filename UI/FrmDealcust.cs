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
    public partial class FrmDealcust : Form
    {
        public FrmDealcust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        deacustBLL dc = new deacustBLL();
        deacustDAL dcdal = new deacustDAL();
        userDAL udal = new userDAL();

        private void btnADD_Click(object sender, EventArgs e)
        {
            //getting data from UI
            dc.type = cmbType.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;

            dc.added_date = DateTime.Now;

            //getting username of the logged in user
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;


            //Inserting Data Into Database

            bool success = dcdal.Insert(dc);
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
            DataTable dt = dcdal.select();
            dgvDeaCust.DataSource = dt;
        }
        private void clear()
        {
            txtDeaCustID.Text = "";
            cmbType.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";

        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of the particular row
            int rowIndex = e.RowIndex;
            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbType.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //getting data from UI
            dc.id = Convert.ToInt32(txtDeaCustID.Text);
            dc.type = cmbType.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;

            dc.added_date = DateTime.Now;

            //getting username of the logged in user
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;



            //Updating Data Into Database

            bool success = dcdal.Update(dc);
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
            DataTable dt = dcdal.select();
            dgvDeaCust.DataSource = dt;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            //getting userID from form
            dc.id = int.Parse(txtDeaCustID.Text);


            //delete data from Database

            bool success = dcdal.Delete(dc);

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
            DataTable dt = dcdal.select();
            dgvDeaCust.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txtSearch.Text;

            //check if the keyword has value or not
            if (keywords != null)
            {
                //show user based on keywords
                DataTable dt = dcdal.Search(keywords);
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dcdal.select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
