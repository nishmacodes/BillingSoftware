using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing_System.BLL;
using System.Security.Cryptography.X509Certificates;

namespace Billing_System.DAL
{
    internal class productsDAL
    {
        //static string string to connect database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method for product module
        public DataTable select()
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //sql query to get data from database
                string sql = "SELECT * FROM tbl_products";
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
        #region Insert Method 
        public bool Insert(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_products(name,category,description,rate,qty,added_date,added_by) VALUES(@name,@category,@description,@rate,@qty,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is executedsuccessfully then the value to rows will be greater than 0 elseelse it will be less than 0
                if (rows > 0)
                {
                    //query successful
                    isSuccess = true;
                }
                else
                {
                    //query failed
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
        #region Update Method

        public bool Update(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_products SET name=@name,category=@category,description=@description,rate=@rate,added_date=@added_date,added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                //cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is executedsuccessfully then the value to rows will be greater than 0 elseelse it will be less than 0
                if (rows > 0)
                {
                    //query successful
                    isSuccess = true;
                }
                else
                {
                    //query failed
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
        #region Delete Method
        public bool Delete(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_products WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is executedsuccessfully then the value to rows will be greater than 0 elseelse it will be less than 0
                if (rows > 0)
                {
                    //query successful
                    isSuccess = true;
                }
                else
                {
                    //query failed
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
        #region Search Method
        public DataTable Search(string keywords)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //sql query to get data from database
                string sql = "SELECT * FROM tbl_products WHERE id LIKE @Keywords OR name LIKE @Keywords OR category LIKE @keywords OR rate LIKE @keywords OR qty LIKE @keywords OR description LIKE @Keywords";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keywords", "%" + keywords + "%");

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
        #region Method to Search PRODUCT FOR Transaction Module
        public productsBLL SearchProductsForTransaction(string keyword)
        {
            //create an object for productsBLL class
            productsBLL p = new productsBLL();

            //create a database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create a datatble to hold the value temporarily
            DataTable dt = new DataTable();
            try
            {
                //write a sql query to search Products based on keywords
                string sql = "SELECT name,rate,qty FROM tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                //create a sql datadapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //transfer the data from dataadapter to datatable
                adapter.Fill(dt);
                //if we have values in dt we need to save it in dealerCusomer BLL
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());




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
            return p;
        }
        #endregion
        #region METHOD TO GET PRODUCT ID BASED ON PRODUCT NAME
        public productsBLL GetProductIDFromName(string ProductName)
        {
            productsBLL p = new productsBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id FROM tbl_products WHERE name='" + ProductName + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["ID"].ToString());
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
            return p;
        }


        #endregion
        #region METHOD TO GET CURRENT QUANTITY OF PRODUCT FROM DATABASE BASED ON PRODUCTID

        public decimal GetProductQty(int ProductID)
        {
            //sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            //create a decimal variable and set its default value to 0
            decimal qty = 0;

            //create datatable to save the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //write sql query to get quantity from database
                string sql = "SELECT qty FROM tbl_products WHERE id=" + ProductID;
                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql dataadapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                //pass the value from dataadapter to datatable
                adapter.Fill(dt);

                //lets check if the dataatble have value or not
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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


            return qty;
        }

        #endregion
        #region METHOD TO UPDATE QUANTITY

        public bool UpdateQuantity(int ProductID, int Qty)
        {
            //create a boolean variable and set its value to false
            bool success = false;
            //sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng);
            //create datatable to save the data from database temporarily

            try
            {
                //write sql query to update quantity from database
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the value through parameters
                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);



                conn.Open();

                //create int variable and check wheathe the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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
            return success;
        }
        #endregion
        #region METHOD TO INCREASE PRODUCT
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //get the current qty from database based on productid
                decimal currentQty = GetProductQty(ProductID);

                //increase the current qty by te qty purchase from dealer
                decimal NewQty = currentQty + IncreaseQty;

                //update the product quantity now
                success = UpdateQuantity(ProductID, (int)NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region METHOD TO DECREASE PRODUCT
        public bool DecreaseProduct(int ProductID, decimal DecreaseQty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //get the current qty from database based on productid
                decimal currentQty = GetProductQty(ProductID);

                //increase the current qty by te qty purchase from dealer
                decimal NewQty = currentQty - DecreaseQty;

                //update the product quantity now
                success = UpdateQuantity(ProductID, (int)NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region DISPLAY PRODUCTS BASED ON CATEGORIES

        public DataTable DisplayProductsByCategory(string category)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //sql query to get data from database       
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";
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


