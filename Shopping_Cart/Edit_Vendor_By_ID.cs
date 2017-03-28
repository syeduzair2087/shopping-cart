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
    public partial class Edit_Vendor_By_ID : Form
    {
        int VID = 0;

        public Edit_Vendor_By_ID()
        {
            InitializeComponent();
        }

        public Edit_Vendor_By_ID(int ID, string Name)
        {
            InitializeComponent();
            VID = ID;
            txtVendorName.Text = Name;
        }

        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtVendorName.Text) || String.IsNullOrWhiteSpace(txtVendorName.Text)))
            {
                GeneralMethods.UpdateVendor(VID, txtVendorName.Text);
                MessageBox.Show("Vendor successfully updated!");
                this.Close();
            }

            else
                MessageBox.Show("Please enter a valid name for the vendor!", "Error");
        }
    }
}
