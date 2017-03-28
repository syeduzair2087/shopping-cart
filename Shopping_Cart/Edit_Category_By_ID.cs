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
    public partial class Edit_Category_By_ID : Form
    {
        int CID = 0;

        public Edit_Category_By_ID()
        {
            InitializeComponent();
        }

        public Edit_Category_By_ID(int ID, string Name)
        {
            InitializeComponent();
            CID = ID;
            txtCategoryName.Text = Name;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtCategoryName.Text) || String.IsNullOrWhiteSpace(txtCategoryName.Text)))
            {


                GeneralMethods.UpdateCategory(CID, txtCategoryName.Text);
                MessageBox.Show("Category successfully updated!");
                this.Close();
            }

            else
                MessageBox.Show("Please enter a valid name for the category!", "Error");
        }
    }
}
