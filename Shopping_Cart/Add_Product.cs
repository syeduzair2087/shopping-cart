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
    public partial class Add_Product : Form
    {
        int ID = 0;

        public Add_Product()
        {
            InitializeComponent();
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.DisplayMember = "catname";
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = "Choose a Category";
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.DisplayMember = "vname";
            cmbVendor.SelectedIndex = -1;
            cmbVendor.Text = "Choose a Vendor";
        }

        public Add_Product(int PID)
        {
            InitializeComponent();
            ID = PID;
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.DisplayMember = "catname";
            cmbCategory.SelectedIndex = -1;
            
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.DisplayMember = "vname";
            cmbVendor.SelectedIndex = -1;

            DataTable ProductDetails = new DataTable();
            ProductDetails = GeneralMethods.GetProductByID(PID);

            cmbCategory.Text = (string)ProductDetails.Rows[0][0];
            cmbVendor.Text = (string)ProductDetails.Rows[0][1];
            
            txtName.Text = (string)ProductDetails.Rows[0][2];
            txtProfit.Text = Convert.ToString(ProductDetails.Rows[0][3]);

            rtxtDescription.Text = Convert.ToString(ProductDetails.Rows[0][4]);

            btnAddProduct.Visible = false;
            btnUpdateProduct.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string ProductName, Description;
            int CategoryID = 0, VendorID = 0, ProfitRate;
            bool ValidSubmission = true;

            if (String.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please select a category for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(cmbVendor.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please select a vendor for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a name for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(txtProfit.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a profit rate for the product!", "Error");
            }

            else if (!(Int32.TryParse(txtProfit.Text, out ProfitRate)))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a valid profit rate!", "Error");
            }





            if (!(GeneralMethods.CheckCategory(cmbCategory.Text)))
            {
                if (MessageBox.Show("Are you sure you want to add a new category?", "Add New Category", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    GeneralMethods.AddCategory(cmbCategory.Text);
                    MessageBox.Show("Category added successfuly!", "Success");
                }
                CategoryID = GeneralMethods.GetCategory(cmbCategory.Text);
            }

            else if (GeneralMethods.CheckCategory(cmbCategory.Text))
            {
                CategoryID = GeneralMethods.GetCategory(cmbCategory.Text);
            }






            if (!(GeneralMethods.CheckVendor(cmbVendor.Text)))
            {
                if (MessageBox.Show("Are you sure you want to add a new vendor?", "Add New Vendor", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    GeneralMethods.AddVendor(cmbVendor.Text);
                    MessageBox.Show("Vendor added successfuly!", "Success");
                }
                VendorID = GeneralMethods.GetVendor(cmbVendor.Text);
            }

            else if (GeneralMethods.CheckVendor(cmbVendor.Text))
            {
                VendorID = GeneralMethods.GetVendor(cmbVendor.Text);
            }

            if (ValidSubmission)
            {
                ProductName = txtName.Text;
                ProfitRate = Convert.ToInt32(txtProfit.Text);
                Description = rtxtDescription.Text;
                GeneralMethods.AddProduct(CategoryID, VendorID, ProductName, ProfitRate, Description);
                GeneralMethods.CreatePurchaseOrderMethod();
                MessageBox.Show("Product added successfully!", "Success");
                

                //int id = GeneralMethods.GetPurchaseOrderID();
                //GeneralMethods.CreatePurchaseOrderTransaction(id, VendorID, GeneralMethods.GetProductID(), 10);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string ProductName, Description;
            int CategoryID = 0, VendorID = 0, ProfitRate;
            bool ValidSubmission = true;

            if (String.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please select a category for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(cmbVendor.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please select a vendor for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a name for the product!", "Error");
            }

            else if (String.IsNullOrWhiteSpace(txtProfit.Text))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a profit rate for the product!", "Error");
            }

            else if (!(Int32.TryParse(txtProfit.Text, out ProfitRate)))
            {
                ValidSubmission = false;
                MessageBox.Show("Please enter a valid profit rate!", "Error");
            }





            if (!(GeneralMethods.CheckCategory(cmbCategory.Text)))
            {
                if (MessageBox.Show("Are you sure you want to add a new category?", "Add New Category", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    GeneralMethods.AddCategory(cmbCategory.Text);
                    MessageBox.Show("Category added successfuly!", "Success");
                }
                CategoryID = GeneralMethods.GetCategory(cmbCategory.Text);
            }

            else if (GeneralMethods.CheckCategory(cmbCategory.Text))
            {
                CategoryID = GeneralMethods.GetCategory(cmbCategory.Text);
            }






            if (!(GeneralMethods.CheckVendor(cmbVendor.Text)))
            {
                if (MessageBox.Show("Are you sure you want to add a new vendor?", "Add New Vendor", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    GeneralMethods.AddVendor(cmbVendor.Text);
                    MessageBox.Show("Vendor added successfuly!", "Success");
                }
                VendorID = GeneralMethods.GetVendor(cmbVendor.Text);
            }

            else if (GeneralMethods.CheckVendor(cmbVendor.Text))
            {
                VendorID = GeneralMethods.GetVendor(cmbVendor.Text);
            }

            if (ValidSubmission)
            {
                ProductName = txtName.Text;
                ProfitRate = Convert.ToInt32(txtProfit.Text);
                Description = rtxtDescription.Text;
                GeneralMethods.UpdateProduct(ID, CategoryID, VendorID, ProductName, ProfitRate, Description);
                MessageBox.Show("Product updated successfully!", "Success");
                this.Close();
            }
        }
    }
}
