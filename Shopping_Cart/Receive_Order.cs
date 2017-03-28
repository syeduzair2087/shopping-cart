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
    public partial class Receive_Order : Form
    {
        BindingSource ProductsData = new BindingSource();
        BindingSource ProductsReceived = new BindingSource();
        DataTable ProductsReceivedTable = new DataTable();
        int UserID = 0;
        int ROID = 0;

        public Receive_Order(int ID)
        {
            InitializeComponent();
            UserID = ID;
            

            //ProductsReceivedTable.Columns.Add("rotid");
            //ProductsReceivedTable.Columns.Add("roid");
            ProductsReceivedTable.Columns.Add("ID");
            ProductsReceivedTable.Columns.Add("Product");
            ProductsReceivedTable.Columns.Add("Quantity");
            ProductsReceivedTable.Columns.Add("Total Price");


            ProductsReceived.DataSource = ProductsReceivedTable;
            dgvReceivedProducts.DataSource = ProductsReceived;
            

            ProductsData.DataSource = GeneralMethods.GetProductsForReceiveOrder();
            dgvProducts.DataSource = ProductsData;
            dgvProducts.ClearSelection();
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.DisplayMember = "vname";
            cmbVendor.SelectedIndex = -1;
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.DisplayMember = "catname";
            cmbCategory.SelectedIndex = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ProductsData.Filter = String.Format("Name like '*{0}*' and Vendor like '*{1}*' and Category like '*{2}*'", txtSearch.Text, cmbVendor.Text, cmbCategory.Text);
        }

        
        private void cmbVendor_TextChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int q, p;

            if (String.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity first!", "Error!");
            }

            else if (!(Int32.TryParse(txtQuantity.Text, out q)))
            {
                MessageBox.Show("Please enter a valid quantity!", "Error!");
            }

            else if (String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter price first!", "Error!");
            }

            else if (!(Int32.TryParse(txtPrice.Text, out p)))
            {
                MessageBox.Show("Please enter a valid price!", "Error!");
            }

            else
            {
                int pid = (int)(dgvProducts.SelectedRows[0].Cells[0].Value), rotquantity = Convert.ToInt32(txtQuantity.Text);
                float rottotalamount = Convert.ToSingle(txtPrice.Text);
                string pname = ((GeneralMethods.GetProductByID(pid)).Rows[0][2]).ToString();
                ProductsReceivedTable.Rows.Add(pid, pname, rotquantity, rottotalamount);
            }

            
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ProductsReceivedTable.Rows.Count != 0)
            {

                //if (GeneralMethods.CreateNewReceieveOrder())
                //{
                    GeneralMethods.CreateReceiveOrder(UserID);
                    ROID = GeneralMethods.GetReceiveOrderID();
                    //GeneralMethods.CreatePurchaseOrder();

                    foreach (DataRow row in ProductsReceivedTable.Rows)
                    {
                        int pid = (Convert.ToInt32(row["ID"]));
                        int quantity = (Convert.ToInt32(row[2]));
                        float amount = (Convert.ToSingle(row[3]));
                        GeneralMethods.CreateReceiveOrderTransaction(ROID, UserID, pid, quantity, amount);

                        float Price = amount / quantity;
                        int Profit = GeneralMethods.GetProfitRate(pid);
                        float SellingPrice = ((Price / 100) * Profit) + Price;
                        int OldQuantity = GeneralMethods.GetQuantity(pid);
                        GeneralMethods.UpdateProductQuantityAndPrice(pid, (quantity + OldQuantity), Price, SellingPrice);


                        //if ((GeneralMethods.GetPreviousPurchaseOrderQuantity(pid) - quantity) > 0)
                        //{
                        //    GeneralMethods.CreatePurchaseOrderAfterReceive(GeneralMethods.GetProductVendor(pid), pid, (GeneralMethods.GetPreviousPurchaseOrderQuantity(pid) - quantity));

                        //}



                    }

                    //DataTable LastPurchaseOrder = new DataTable();
                    //DataTable NewPurchaseOrder = new DataTable();
                    //LastPurchaseOrder = GeneralMethods.GetPurchaseOrderTransactionTable((GeneralMethods.GetPurchaseOrderID() - 1));
                    //NewPurchaseOrder = GeneralMethods.GetPurchaseOrderTransactionTable(GeneralMethods.GetPurchaseOrderID());

                    //foreach (DataRow row in LastPurchaseOrder.Rows)
                    //{
                    //    bool Present = false;
                    //    int VendorID = 0;
                    //    int Quantity = 0;

                    //    int pid = Convert.ToInt32(row["pid"]);
                    //    foreach (DataRow NewRow in NewPurchaseOrder.Rows)
                    //    {
                    //        int npid = Convert.ToInt32(NewRow["pid"]);

                    //        if (npid == pid)
                    //        {
                    //            Present = true;
                    //            break;
                    //        }

                    //        VendorID = Convert.ToInt32(row["vid"]);
                    //        Quantity = Convert.ToInt32(row["potquantity"]);

                    //        if (!Present)
                    //        {
                    //            GeneralMethods.CreatePurchaseOrderAfterReceive(VendorID, pid, Quantity);
                    //        }
                    //    }


                    //}

                    GeneralMethods.CreatePurchaseOrderMethod();
                    MessageBox.Show("Receive Order Successfully Created!", "Success!");
                //}
            }

            else
            {
                MessageBox.Show("Please select some items first!", "Error!");
            }
        }

        private void dgvReceivedProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if ((MessageBox.Show("Remove this product from list?", "Confirm", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    ProductsReceived.RemoveCurrent();
                }
            }
        }

        

        

    }
}
