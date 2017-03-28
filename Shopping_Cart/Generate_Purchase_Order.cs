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
    public partial class Generate_Purchase_Order : Form
    {
        BindingSource PurchaseOrderData = new BindingSource();
        BindingSource TransactionData = new BindingSource();

        public Generate_Purchase_Order()
        {
            InitializeComponent();
            PurchaseOrderData.DataSource = GeneralMethods.GetPurchaseOrders();
            //dgvPurchaseOrdersTransactions.DataSource = PurchaseOrderData;
            lstPurchaseOrder.DataSource = PurchaseOrderData;
            lstPurchaseOrder.DisplayMember = "date";
            lstPurchaseOrder.ValueMember = "poid";
            


            //if (GeneralMethods.CreateNewPurchaseOrder())
            //{

            //    DataTable Products = new DataTable();
            //    Products = GeneralMethods.GetProductsTable();
            //    GeneralMethods.CreatePurchaseOrder();
            //    int ID = GeneralMethods.GetPurchaseOrderID();

            //    foreach (DataRow row in Products.Rows)
            //    {
            //        if (((int)(row["quantity"])) <= 10)
            //        {
            //            int PID = ((int)(row["pid"]));
            //            int VID = ((int)(row["vid"]));
            //            int Quantity = 10;
            //            GeneralMethods.CreatePurchaseOrderTransaction(ID, VID, PID, Quantity);
            //        }
            //    }
            //}
            //GeneralMethods.CreatePurchaseOrderMethod();
        }

        //private void dgvPurchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int id = Convert.ToInt32(dgvPurchaseOrdersTransactions.Rows[dgvPurchaseOrdersTransactions.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString());
        //}

        private void lstPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(lstPurchaseOrder.SelectedIndex < 0))
            {
                int param = 0;
                //Convert.ToInt32(lstPurchaseOrder.SelectedValue.ToString());
                Int32.TryParse(lstPurchaseOrder.SelectedValue.ToString(), out param);
                TransactionData.DataSource = GeneralMethods.GetPurchaseOrderTransaction(param);
                dgvPurchaseOrdersTransactions.DataSource = TransactionData;
            }
            //if (lstPurchaseOrder.SelectedIndex >= 0)
            //{
            //    //MessageBox.Show((lstPurchaseOrder.SelectedValue.ToString()));
            //    int param = 0;
            //        //Convert.ToInt32(lstPurchaseOrder.SelectedValue.ToString());
            //    Int32.TryParse(lstPurchaseOrder.SelectedValue.ToString(), out param);
            //    TransactionData.DataSource = GeneralMethods.GetPurchaseOrderTransaction(param);
            //}
        }

        private void lstPurchaseOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPurchaseOrdersTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgvPurchaseOrdersTransactions.SelectedRows[0].Cells[1].FormattedValue) == GeneralMethods.GetPurchaseOrderID())
            {
                int POTID = Convert.ToInt32(dgvPurchaseOrdersTransactions.SelectedRows[0].Cells[0].FormattedValue);
                int Quantity = Convert.ToInt32(dgvPurchaseOrdersTransactions.SelectedRows[0].Cells[4].FormattedValue);
                Form UpdateQuantityForm = new Update_Purchase_Order_Transaction_Quantity(POTID, Quantity);
                UpdateQuantityForm.ShowDialog();

                int POID = Convert.ToInt32(dgvPurchaseOrdersTransactions.SelectedRows[0].Cells[1].FormattedValue);
                TransactionData.DataSource = GeneralMethods.GetPurchaseOrderTransaction(POID);
            }

            else
            {
                MessageBox.Show("Sorry! Only the latest Purchase Order can be edited", "Error");
            }
        }
    }
}
