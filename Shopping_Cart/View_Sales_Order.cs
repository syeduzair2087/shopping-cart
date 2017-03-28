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
    public partial class View_Sales_Order : Form
    {
        BindingSource CustomersData = new BindingSource();
        BindingSource SalesOrdersData = new BindingSource();
        BindingSource TransactionData = new BindingSource();

        public View_Sales_Order()
        {
            InitializeComponent();
            CustomersData.DataSource = GeneralMethods.GetCustomers();
            cmbCustomers.DataSource = CustomersData;
            cmbCustomers.DisplayMember = "cname";
            cmbCustomers.ValueMember = "cid";
            cmbCustomers.SelectedIndex = -1;

            SalesOrdersData.DataSource = GeneralMethods.GetSalesOrders();
            lstSalesOrder.DataSource = SalesOrdersData;
            lstSalesOrder.DisplayMember = "date";
            lstSalesOrder.ValueMember = "soid";
        }

        private void lstSalesOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstSalesOrder.SelectedIndex < 0))
            {
                int param = 0;
                //Convert.ToInt32(lstPurchaseOrder.SelectedValue.ToString());
                Int32.TryParse(lstSalesOrder.SelectedValue.ToString(), out param);
                TransactionData.DataSource = GeneralMethods.GetSalesOrderTransaction(param);
                dgvSalesOrdersTransactions.DataSource = TransactionData;
            }
        }

        private void cmbCustomers_TextChanged(object sender, EventArgs e)
        {
            SalesOrdersData.Filter = String.Format("cname like '*{0}*'", cmbCustomers.Text);
        }

    }
}
