using Billing_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System.DAL
{
    internal class transactionDetailDAL
    {
        //create a connection string 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Transaction Detail Method

        public bool Insert_TransactionDetail(transactionDetailBLL td)
        {
            //create a boolean value and set its default value to false
            bool isSuccess = false;
           
            //create a sqlconnection first
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query to Insert Transaction
                string sql = "INSERT INTO tbl_transaction_detail(product_id,rate,qty,total,deal_cust_id,added_date,added_by)VALUES(@product_id,@rate,@qty,@total,@deal_cust_id,@added_date,@added_by)";

                //sql commands to pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the value to sql query using cmd
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@deal_cust_id", td.deal_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                //open databse connection
                conn.Open();

                //declare the int variable and execute the query
                int rows=cmd.ExecuteNonQuery();
                
                if (rows>0)
                {
                   //query executed successfully
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

    }
}
