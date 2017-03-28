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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (GeneralMethods.GetUserCount() == 0)
                GeneralMethods.AddUser("Administrator");

            if (GeneralMethods.GetCustomerCount() == 0)
                GeneralMethods.AddCustomer("Walk-In Customer", "", "");

            cmbUserType.Text = "Select User Type";
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnViewSalesOrder.Enabled = false;
            btnViewReceiveOrder.Enabled = false;
            btnView.Enabled = false;
            btnShopping.Enabled = false;
            btnRO.Enabled = false;
            btnPO.Enabled = false;

            if (cmbUserType.SelectedIndex == 0)
            {
                cmbUserName.DataSource = GeneralMethods.GetCustomers();
                cmbUserName.DisplayMember = "cname";
                cmbUserName.ValueMember = "cid";;
                cmbUserName.SelectedIndex = -1;
                cmbUserName.Text = "Select a Customer";

                btnNewUser.Enabled = true;
            }

            else if (cmbUserType.SelectedIndex == 1)
            {
                cmbUserName.DataSource = GeneralMethods.GetUsers();
                cmbUserName.DisplayMember = "uname";
                cmbUserName.ValueMember = "uid";
                cmbUserName.SelectedIndex = -1;
                cmbUserName.Text = "Select an Administrator";

                btnNewUser.Enabled = true;
            }

            else if (cmbUserType.SelectedIndex < 0)
            {
                cmbUserType.Text = "Select User Type";
                cmbUserName.DataSource = null;
                btnNewUser.Enabled = false;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedIndex == 0)
            {
                Form AddCustomer = new NewCustomer();
                this.Hide();
                AddCustomer.ShowDialog();
                this.Show();
                cmbUserType_SelectedIndexChanged(sender, e);
            }

            else if (cmbUserType.SelectedIndex == 1)
            {
                Form AddUser = new NewUser();
                this.Hide();
                AddUser.ShowDialog();
                this.Show();                
                cmbUserType_SelectedIndexChanged(sender, e);
            }
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex >= 0 && cmbUserType.SelectedIndex == 0)
            {
                btnShopping.Enabled = true;
                btnPO.Enabled = false;
                btnRO.Enabled = false;
                btnView.Enabled = false;
                btnViewSalesOrder.Enabled = false;
            }


            else if (cmbUserName.SelectedIndex >= 0 && cmbUserType.SelectedIndex == 1)
            {
                btnShopping.Enabled = false;
                btnPO.Enabled = true;
                btnRO.Enabled = true;
                btnView.Enabled = true;
                btnViewReceiveOrder.Enabled = true;
                btnViewSalesOrder.Enabled = true;
            }

            else if (cmbUserName.SelectedIndex < 0)
            {
                btnShopping.Enabled = false;
                btnPO.Enabled = false;
                btnRO.Enabled = false;
                btnView.Enabled = false;
                btnViewReceiveOrder.Enabled = false;
                btnViewSalesOrder.Enabled = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form ViewProduct = new Products();
            this.Hide();
            ViewProduct.ShowDialog();
            this.Show();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            Form PurchaseOrderForm = new Generate_Purchase_Order();
            this.Hide();
            PurchaseOrderForm.ShowDialog();
            this.Show();
        }

        private void btnRO_Click(object sender, EventArgs e)
        {
            Form PurchaseOrderForm = new Receive_Order(Convert.ToInt32(cmbUserName.SelectedValue));
            this.Hide();
            PurchaseOrderForm.ShowDialog();
            this.Show();
        }

        private void btnViewReceiveOrder_Click(object sender, EventArgs e)
        {
            Form ViewReceiveOrderForm = new View_Receive_Order();
            this.Hide();
            ViewReceiveOrderForm.ShowDialog();
            this.Show();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            Form SalesOrderForm = new Sales_Order(Convert.ToInt32(cmbUserName.SelectedValue));
            this.Hide();
            SalesOrderForm.ShowDialog();
            this.Show();
        }

        private void btnViewSalesOrder_Click(object sender, EventArgs e)
        {
            Form SalesOrderForm = new View_Sales_Order();
            this.Hide();
            SalesOrderForm.ShowDialog();
            this.Show();
        }
    }
}
