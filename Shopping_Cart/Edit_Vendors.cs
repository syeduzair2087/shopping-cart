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
    public partial class Edit_Vendors : Form
    {
        BindingSource VendorsData = new BindingSource();

        public Edit_Vendors()
        {
            InitializeComponent();
            VendorsData.DataSource = GeneralMethods.GetVendors();
            //dgvVendors.DataSource = VendorsData;
            lstVendors.DataSource = VendorsData;
            lstVendors.DisplayMember = "vname";
            lstVendors.ValueMember = "vid";
        }

        //public Edit_Vendors()
        //{
        //    InitializeComponent();
        //}

        private void dgvVendors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = Convert.ToInt32(dgvVendors.Rows[dgvVendors.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString());
            int id = ((int)(lstVendors.SelectedValue));
            //string vname = (dgvVendors.Rows[dgvVendors.CurrentCell.RowIndex].Cells[1].FormattedValue.ToString());
            string vname = lstVendors.SelectedItem.ToString();
            Form EditVendor = new Edit_Vendor_By_ID(id, vname);
            EditVendor.ShowDialog();
            VendorsData.DataSource = GeneralMethods.GetVendors();
        }

        private void lstVendors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstVendors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int id = Convert.ToInt32(dgvVendors.Rows[dgvVendors.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString());
            int id = ((int)(lstVendors.SelectedValue));
            //string vname = (dgvVendors.Rows[dgvVendors.CurrentCell.RowIndex].Cells[1].FormattedValue.ToString());
            string vname = ((DataRowView)(lstVendors.SelectedItem)).Row[1].ToString();
            Form EditVendor = new Edit_Vendor_By_ID(id, vname);
            EditVendor.ShowDialog();
            VendorsData.DataSource = GeneralMethods.GetVendors();
        }
    }
}
