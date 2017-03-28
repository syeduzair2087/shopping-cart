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
    public partial class Update_Purchase_Order_Transaction_Quantity : Form
    {
        int ID = 0;

        public Update_Purchase_Order_Transaction_Quantity(int POTID, int Quantity)
        {
            InitializeComponent();
            txtQuantity.Text = Quantity.ToString();
            ID = POTID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.All(Char.IsDigit) && (!(String.IsNullOrWhiteSpace(txtQuantity.Text))))
            {
                GeneralMethods.UpdatePurchaseOrderTransactionQuantity(ID, Convert.ToInt32(txtQuantity.Text));
                MessageBox.Show("Successfully updated!", "Success");

                this.Close();
            }

            else if (!(txtQuantity.Text.All(Char.IsDigit)))
            {
                MessageBox.Show("Quantity must only contain numbers!", "Error");
            }

            else
            {
                MessageBox.Show("Field cannot be left empty!");
            }
        }


    }
}
