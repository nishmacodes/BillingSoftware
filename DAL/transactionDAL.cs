using Billing_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System.DAL
{
    internal class transactionDAL
    {
        //create a connection string variable
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Transaction Method
        public bool Insert_Transaction(transactionsBLL t, out int transactionID)
        {
            //create a boolean value and set its default value to false
            bool isSuccess = false;
            //set the out transactiomID value to negative 1 i.e. -1
            transactionID = -1;
            //create a sqlconnection first
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query to Insert Transaction
                string sql = "INSERT INTO tbl_transactions(type,deal_cust_id,grandTotal,transaction_date,tax,discount,added_by)VALUES(@type,@deal_cust_id,@grandTotal,@transaction_date,@tax,@discount,@added_by);SELECT @@identity;";

                //sql commands to pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the value to sql query using cmd
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@deal_cust_id", t.deal_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                //open databse connection
                conn.Open();


                //execute the query
                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    //query executed successfully
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
                    //failed to execute query
                    isSuccess = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        #endregion
        #region METHOD TO DISPLAY ALL THE TRANSACTIONS

        public DataTable DisplayAllTransactions()
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //sql query to get data from database
                string sql = "SELECT * FROM tbl_transactions";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //databse connection open
                conn.Open();
                //fill data in datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //throw if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing connection
                conn.Close();
            }
            //return the value in datatable
            return dt;
        }


            #endregion

            #region METHOD TO DISPLAY  TRANSACTIONS BASED ON TRANSACTION TYPE

        public DataTable DisplayTransactionByType(string type)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //sql query to get data from database       
                string sql = "SELECT * FROM tbl_transactions WHERE type='"+type+"'";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //databse connection open
                conn.Open();
                //fill data in datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //throw if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing connection
                conn.Close();
            }
            //return the value in datatable
            return dt;


            #endregion
        }
    }
}
