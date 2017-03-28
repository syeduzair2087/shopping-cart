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
    public partial class Edit_Categories : Form
    {
        BindingSource CategoriesData = new BindingSource();

        public Edit_Categories()
        {
            InitializeComponent();
            CategoriesData.DataSource = GeneralMethods.GetCategories();
            dgvCategories.DataSource = CategoriesData;
        }

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvCategories.Rows[dgvCategories.CurrentCell.RowIndex].Cells[0].FormattedValue.ToString());
            string cname = (dgvCategories.Rows[dgvCategories.CurrentCell.RowIndex].Cells[1].FormattedValue.ToString());
            Form EditCategory = new Edit_Category_By_ID(id, cname);
            EditCategory.ShowDialog();
            CategoriesData.DataSource = GeneralMethods.GetCategories();
        }
    }
}
