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
    public partial class Products : Form
    {
        BindingSource ProductsData = new BindingSource();
        

        public Products()
        {
            InitializeComponent();
            ProductsData.DataSource = GeneralMethods.GetProducts();
            dgvProducts.DataSource = ProductsData;
            dgvProducts.ClearSelection();
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.DisplayMember = "vname";
            cmbVendor.SelectedIndex = -1;
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.DisplayMember = "catname";
            cmbCategory.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddProduct = new Add_Product();
            //this.Hide();
            AddProduct.ShowDialog();
            this.Show();
            ProductsData.DataSource = GeneralMethods.GetProducts();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32 ( dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString() );
            Form AddProduct = new Add_Product(id);
            //this.Hide();
            AddProduct.ShowDialog();
            this.Show();
            ProductsData.DataSource = GeneralMethods.GetProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                ProductsData.Filter = String.Format("Name like '*{0}*' and Vendor like '*{1}*' and Category like '*{2}*'", txtSearch.Text, cmbVendor.Text, cmbCategory.Text);
        }

        private void cmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void cmbVendor_TextChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void dgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if ((MessageBox.Show("Are you sure you wish to delete the selected product data?", "Confirm", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvProducts.Rows[dgvProducts.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString());
                    GeneralMethods.DeleteProduct(id);
                    MessageBox.Show("The data has been deleted successfully!", "Success");
                    ProductsData.DataSource = GeneralMethods.GetProducts();
                }
            }
        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
            Form EditCategories = new Edit_Categories();
            //this.Hide();
            EditCategories.ShowDialog();
            cmbCategory.DataSource = GeneralMethods.GetCategories();
            cmbCategory.SelectedIndex = -1;
            ProductsData.DataSource = GeneralMethods.GetProducts();
            //this.Show();

        }

        private void btnEditVendors_Click(object sender, EventArgs e)
        {
            Form EditVendors = new Edit_Vendors();
            EditVendors.ShowDialog();
            cmbVendor.DataSource = GeneralMethods.GetVendors();
            cmbVendor.SelectedIndex = -1;
            ProductsData.DataSource = GeneralMethods.GetProducts();
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        

        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].FormattedValue.ToString());
        //    Form AddProduct = new Add_Product(id);
        //    //this.Hide();
        //    AddProduct.ShowDialog();
        //    this.Show();
        //}
    }
}
