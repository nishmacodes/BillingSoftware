using Billing_System.BLL;
using Billing_System.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Billing_System.UI
{
    public partial class frmPurchaseandSales : Form
    {
        public frmPurchaseandSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DGVAddedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlDataGridview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the values from PurchaseSales Form first
            transactionsBLL transactions = new transactionsBLL();
            transactions.type = lblTop.Text;
            
            //get the id of dealer or customer
            //lets get the name of dealer/customer first
            string deaCustName=txtName.Text;
            deacustBLL dc=dcDAL.GetDeaCustIDFromName(deaCustName);

            transactions.deal_cust_id = dc.id;
            transactions.grandTotal=Math.Round(decimal.Parse(txtGrandTotal.Text),2);
            transactions.transaction_date = DateTime.Now;
            transactions.tax=decimal.Parse(txtVAT.Text);
            transactions.discount = decimal.Parse(txtDiscount.Text);

            //get the username of logged In User
            string username = FrmLogin.loggedIn;
            userBLL u=uDAL.GetIDFromUsername(username);
            transactions.added_by=u.id;
            //lets create a boole/an variable and set its value to false
            bool success = false;
            
            //actual code to add transaction and transaction detail
            using(TransactionScope scope=new TransactionScope())
            {
                int transactionID = -1;
                //create boolean value and insert transaction
                bool w=tDAL.Insert_Transaction(transactions,out transactionID);

                //use for loop to insert transaction details
                for(int i=0;i<transactionDT.Rows.Count;i++)
                {
                    //get all the details of product
                   transactionDetailBLL transactionDetail=new transactionDetailBLL();
                    //get thye product name and convert it into id
                    string ProductName = transactionDT.Rows[i][0].ToString(); 
                    productsBLL p=pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total=Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetail.deal_cust_id=dc.id;
                    transactionDetail.added_date= DateTime.Now;
                    transactionDetail.added_by = u.id;

                    //increase or decrease product quantity based on purchase or sales
                    string transactionType = lblTop.Text;
                    bool x=false;

                    //lets check wheather we are in purchase or sales
                    if(transactionType =="Purchase")
                    {
                        //increase the product qty
                         x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                         
                    }
                    else if(transactionType =="Sales")
                    {
                        //decrease the product qty
                         x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }

                    //insert transaction detail inside the database 
                    bool y = tdDAL.Insert_TransactionDetail(transactionDetail);
                    success = w && x && y;


                }
                
                    if(success==true)
                    {
                        //transaction complete
                        scope.Complete();


                       //code to print bill
                       DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n ANYSTORE PVT. LTD";
                    printer.SubTitle = "Kerala,India \r\n phone: +91 8593909800";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment= StringAlignment.Near;
                    printer.Footer = "Discount:" + txtDiscount.Text + "%\r\n" +"VAT: "+txtVAT.Text+"%\r\n"+"Grand Total:"+txtGrandTotal.Text+"\r\n"+"Thank you for doing business with us.";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(DGVAddedProducts);



                    MessageBox.Show("Transaction completed successfully");

                    //clear the datagridview and clear all the textboxes
                    DGVAddedProducts.DataSource = null;
                    DGVAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtProductSearch.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVAT.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";


                    }
                    else
                    {
                        //transaction failed
                        MessageBox.Show("Transaction failed");
                    }

            }
        }
        deacustDAL dcDAL = new deacustDAL();
        productsDAL pDAL = new productsDAL();
        DataTable transactionDT = new DataTable();
        userDAL uDAL=new userDAL();
        transactionDAL tDAL=new transactionDAL();   
        transactionDetailDAL tdDAL= new transactionDetailDAL();

        private void frmPurchaseandSales_Load(object sender, EventArgs e)
        {
            //get the transactionType value from userDashboard
            string type = FrmUserDashboard.transactionType;
            //set the value on lblTop
            lblTop.Text = type;

            //specify columns for transaction datatable
           
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from the textbox
            string keyword = txtSearch.Text;
            if (keyword == "")
            {
                //clear all the textboxes
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }
            //write the code to get the details and set the value on textboxes
            deacustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            //now tranfer and set the value from deaCustBLL to textboxes
            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from the textbox
            string keyword = txtProductSearch.Text;
            if (keyword == "")
            {
                //clear all the textboxes
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }
            //write the code to get the details and set the value on textboxes
            productsBLL p = pDAL.SearchProductsForTransaction(keyword);

            //now tranfer and set the value from deaCustBLL to textboxes
            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get product name,rate and qty customer want to buy
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty;

            //display the subtotal in textbox
            //get the total value from textbox
            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            //chech wheather the product is selected or not
            if (productName == "")
            {
                //display error message
                MessageBox.Show("select the product first. Try again.");
            }
            else
            {
                //add product to datagridview
                transactionDT.Rows.Add(productName, Rate, Qty, Total);

                //show in datagridview
                DGVAddedProducts.DataSource = transactionDT;

                //display the subtotal in textbox
                txtSubTotal.Text = subTotal.ToString();

                //clear the textboxes

                txtProductSearch.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";

            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //get the value from discount textbox
            string value = txtDiscount.Text;
            if (value == "")
            {
                //display error message
                MessageBox.Show("please add discount first");


            }
            else
            {
                //get the discount in decimal value
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                //calculate the grandtotal based on discount

                decimal grandTotal = ((100 - discount) / 100) * subTotal;
                //display grandtotal in textbox
                txtGrandTotal.Text = grandTotal.ToString();
            }

        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            //checked if the grandtotal has value or not if it has not value then calculate the discount first
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                //display the error message
                MessageBox.Show("calculate the discount and set the grandtotal first.");
            }
            else
            {
                //calculate VAT
                //getting the VAT percent first
                decimal previousGrandTotal = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVAT.Text);
                decimal grandTotalWithVAT = ((100 + vat) / 100) * previousGrandTotal;

                //display the grandtotal with vat
                txtGrandTotal.Text = grandTotalWithVAT.ToString();
            }

        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            //get the paid amount and grandtotal
            decimal grandTotal=decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount=decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount=paidAmount-grandTotal;
            //display the return amount
            txtReturnAmount.Text = returnAmount.ToString();



        }
    }
}
