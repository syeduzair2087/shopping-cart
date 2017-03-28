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
    public partial class View_Receive_Order : Form
    {
        BindingSource UsersData = new BindingSource();
        BindingSource ReceiveOrdersData = new BindingSource();
        BindingSource TransactionData = new BindingSource();

        public View_Receive_Order()
        {
            InitializeComponent();
            UsersData.DataSource = GeneralMethods.GetUsers();
            cmbUsers.DataSource = UsersData;
            cmbUsers.DisplayMember = "uname";
            //cmbUsers.ValueMember = "uid";
            cmbUsers.SelectedIndex = -1;

            ReceiveOrdersData.DataSource = GeneralMethods.GetReceiveOrders();
            lstReceiveOrder.DisplayMember = "Date";
            lstReceiveOrder.ValueMember = "ID";
            lstReceiveOrder.DataSource = ReceiveOrdersData;

        }

        private void dgvReceiveOrders_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void lstReceiveOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!(lstReceiveOrder.SelectedIndex < 0))
            {
                int param = 0;
                //Convert.ToInt32(lstPurchaseOrder.SelectedValue.ToString());
                //Int32.TryParse(lstReceiveOrder.SelectedValue.ToString(), out param);
                //param = Convert.ToInt32(lstReceiveOrder.SelectedValue.ToString());
                param = (int)lstReceiveOrder.SelectedValue;
                TransactionData.DataSource = GeneralMethods.GetReceiveOrderTransaction(param);
                dgvReceiveOrdersTransactions.DataSource = TransactionData;
            }
        }

        private void cmbUsers_TextChanged(object sender, EventArgs e)
        {
            ReceiveOrdersData.Filter = String.Format("[User Name] like '*{0}*'", cmbUsers.Text);
        }
    }
}
