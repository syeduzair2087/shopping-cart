using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Sales_Order : Form
    {
        BindingSource ProductsData = new BindingSource();
        BindingSource Cart = new BindingSource();
        DataTable CartTable = new DataTable();
        int CustID = 0;
        int SOID = 0;

        public Sales_Order(int ID)
        {
            InitializeComponent();
            CustID = ID;
            

            //ProductsReceivedTable.Columns.Add("rotid");
            //ProductsReceivedTable.Columns.Add("roid");
            CartTable.Columns.Add("ID");
            CartTable.Columns.Add("Product");
            CartTable.Columns.Add("Quantity");
            CartTable.Columns.Add("Total Price");


            Cart.DataSource = CartTable;
            dgvCart.DataSource = Cart;

            ProductsData.DataSource = GeneralMethods.GetProductsForSalesOrder();
            dgvProducts.DataSource = ProductsData;
            dgvProducts.ClearSelection();
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.DisplayMember = "vname";
            cmbVendor.SelectedIndex = -1;
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.DisplayMember = "catname";
            cmbCategory.SelectedIndex = -1;
        }


        

        

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ProductsData.Filter = String.Format("Name like '*{0}*' and Vendor like '*{1}*' and Category like '*{2}*'", txtSearch.Text, cmbVendor.Text, cmbCategory.Text);
        }

        private void cmbVendor_TextChanged_1(object sender, EventArgs e)
        {
            txtSearch_TextChanged_1(sender, e);
        }

        private void cmbCategory_TextChanged_1(object sender, EventArgs e)
        {
            txtSearch_TextChanged_1(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int q;

            if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity first!", "Error");
            }

            else if (!(Int32.TryParse(txtQuantity.Text, out q)))
            {
                MessageBox.Show("Please enter valid quantity!", "Error!");
            }

            else
            {
                int CheckID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);
                
                
                foreach(DataRow row in CartTable.Rows)
                {
                    if (Convert.ToInt32(row[0]) == CheckID)
                    {
                        
                        int Pid = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);
                        int Rotquantity = Convert.ToInt32(txtQuantity.Text);
                        int AvailableQuantity = (int)(dgvProducts.SelectedRows[0].Cells[5].Value);

                        if (Rotquantity > AvailableQuantity)
                        {
                            if (MessageBox.Show(GeneralMethods.GetProductNameByID(Pid) + " is not available in the desired quantity. Do you wish to add the complete quantity avaialable i.e " + AvailableQuantity + " to the cart?", "Oops", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Rotquantity = AvailableQuantity;

                                //float a = Convert.ToSingle(dgvProducts.SelectedRows[0].Cells[4].Value);
                                ////float b = Convert.ToInt32(txtQuantity.Text);
                                //float rottotalamount = a * Rotquantity;
                                //string pname = ((GeneralMethods.GetProductByID(Pid)).Rows[0][2]).ToString();


                                //CartTable.Rows.Add(Pid, pname, Rotquantity, rottotalamount);

                                int Amount = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[4].Value);
                                //int Quantity = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[5].Value);
                                int Quantity = AvailableQuantity;
                                float Price = Amount;
                                //int Profit = GeneralMethods.GetProfitRate(CheckID);
                                //float SellingPrice = ((Price / 100) * Profit) + Price;
                                row[2] = Quantity;
                                row[3] = Price * Quantity;
                                //dgvProducts.SelectedRows[0].Cells[5].Value = (Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[5].Value)) - (Convert.ToInt32(txtQuantity.Text));
                                return;
                                //break;

                            }

                        }



                        else
                        {
                            int Amount = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[4].Value);
                            int Quantity = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[5].Value);
                            //int Quantity = AvailableQuantity;
                            float Price = Amount ;
                            //int Profit = GeneralMethods.GetProfitRate(CheckID);
                            //float SellingPrice = ((Price / 100) * Profit) + Price;
                            row[2] = txtQuantity.Text;
                            row[3] = Price * Convert.ToInt32(txtQuantity.Text);
                            //dgvProducts.SelectedRows[0].Cells[5].Value = (Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[5].Value)) - (Convert.ToInt32(txtQuantity.Text));
                            return;
                        }


                        
                    }
                }


                
                int pid = (int)(dgvProducts.SelectedRows[0].Cells[0].Value), rotquantity = Convert.ToInt32(txtQuantity.Text);
                int availableQuantity = (int)(dgvProducts.SelectedRows[0].Cells[5].Value);

                if (rotquantity > availableQuantity)
                {
                    if (availableQuantity == 0)
                    {
                        MessageBox.Show("Sorry! The selected product is Out of Stock..\nPlease Try again later..", "Sorry!");
                    }

                    else if (MessageBox.Show(GeneralMethods.GetProductNameByID(pid) + " is not available in the desired quantity. Do you wish to add the complete quantity avaialable i.e " + availableQuantity + " to the cart?", "Oops", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rotquantity = availableQuantity;

                        float a = Convert.ToSingle(dgvProducts.SelectedRows[0].Cells[4].Value);
                        //float b = Convert.ToInt32(txtQuantity.Text);
                        float rottotalamount = a * rotquantity;
                        string pname = ((GeneralMethods.GetProductByID(pid)).Rows[0][2]).ToString();


                        CartTable.Rows.Add(pid, pname, rotquantity, rottotalamount);
                        
                    }

                }

                else
                {
                    float a = Convert.ToSingle(dgvProducts.SelectedRows[0].Cells[4].Value);
                    //float b = Convert.ToInt32(txtQuantity.Text);
                    float rottotalamount = a * rotquantity;
                    string pname = ((GeneralMethods.GetProductByID(pid)).Rows[0][2]).ToString();


                    CartTable.Rows.Add(pid, pname, rotquantity, rottotalamount);
                    //dgvProducts.SelectedRows[0].Cells[5].Value = (Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[5].Value)) - (Convert.ToInt32(txtQuantity.Text));
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CartTable.Rows.Count != 0)
            {
                GeneralMethods.CreateSalesOrder(CustID);
                SOID = GeneralMethods.GetSalesOrderID();
                int Sum = 0;

                foreach (DataRow row in CartTable.Rows)
                {
                    int pid = (Convert.ToInt32(row["ID"]));
                    int quantity = (Convert.ToInt32(row[2]));
                    float amount = (Convert.ToSingle(row[3]));
                    int OldQuantity = GeneralMethods.GetQuantity(pid);

                    Sum += (int)amount;



                    GeneralMethods.CreateSalesOrderTransaction(SOID, pid, quantity, amount);

                    float Price = amount / quantity;
                    int Profit = GeneralMethods.GetProfitRate(pid);
                    float SellingPrice = ((Price / 100) * Profit) + Price;

                    GeneralMethods.UpdateProductQuantityOnSale(pid, (OldQuantity - quantity));
                    GeneralMethods.CreatePurchaseOrderMethod();


                    //if ((GeneralMethods.GetPreviousPurchaseOrderQuantity(pid) - quantity) > 0)
                    //{
                    //    GeneralMethods.CreatePurchaseOrderAfterReceive(GeneralMethods.GetProductVendor(pid), pid, (GeneralMethods.GetPreviousPurchaseOrderQuantity(pid) - quantity));

                    //}

                    //GeneralMethods.CreatePurchaseOrderMethod();
                }

                MessageBox.Show("Your total bill:\t" + Sum + "\nThank You For Shopping!", "Success!");
            }

            else
            {
                MessageBox.Show("Please add some items to cart first!", "Error!");
            }
        }

        private void dgvCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if ((MessageBox.Show("Remove selected product from cart?", "Confirm", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    Cart.RemoveCurrent();
                }
            }
        }       

    }
    
}
