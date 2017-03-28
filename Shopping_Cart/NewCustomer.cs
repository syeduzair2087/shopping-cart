﻿using System;
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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GeneralMethods.AddCustomer(txtNewCustomerName.Text, txtNewCustomerContact.Text, txtNewCustomerAddress.Text);
            MessageBox.Show("Member was added successfully!");
            this.Close();
        }
    }
}
