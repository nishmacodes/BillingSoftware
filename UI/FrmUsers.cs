﻿using Billing_System.BLL;
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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        //objects
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            dgvUsers.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {    
            
            //getting data from UI
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;

            //getting username of the logged in user
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;
            

            //Inserting Data Into Database

            bool success = dal.Insert(u);
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
            dgvUsers.DataSource = dt;


        }

        private void clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of the particular row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //get the values from user UI

            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            //getting ID in added by field
            string loggedUser = FrmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;



            //Updating Data Into Database

            bool success = dal.Update(u);
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
            dgvUsers.DataSource = dt;

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {
            //getting userID from form
            u.id = Convert.ToInt32(txtUserID.Text);


            //delete data from Database

            bool success = dal.Delete(u);

            //if the data  is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                //data deleted successfully
                MessageBox.Show("User Successfully daleted");
                clear();

            }
            else
            {
                //failed to delete data            
                MessageBox.Show("failed to delete user");
            }
            //refreshing data grid view
            DataTable dt = dal.select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox
            string keywords = txtSearch.Text;

            //check if the keyword has value or not
            if (keywords !=null)
            {
                //show user based on keywords
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource= dt;
            }
            else
            {
                //show all users from the database
                DataTable dt=dal.select();
                dgvUsers.DataSource=dt;
            }
        }
    }
}

