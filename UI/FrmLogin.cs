using Billing_System.BLL;
using Billing_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pboxClose_Click(object sender, EventArgs e)
        {
            //code to close this form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type=cmbUserType.Text.Trim();

            //checking the login credentials
            bool success=dal.LoginCheck(l);
            if (success == true)
            {
                //login successful
                MessageBox.Show("Login Successful");
                loggedIn=l.username;
                //need to open respective forms based on usertype
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin dashboard
                            FrmAdminDashboard admin = new FrmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //display admin dashboard
                            FrmUserDashboard user = new FrmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //display an error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;

                }
            }


            else
            {
                MessageBox.Show("Login Failed.Try Again");
            }

            
        }

    }
}
