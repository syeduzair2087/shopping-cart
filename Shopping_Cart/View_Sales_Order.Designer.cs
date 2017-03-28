namespace Shopping_Cart
{
    partial class View_Sales_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSalesOrder = new System.Windows.Forms.ListBox();
            this.dgvSalesOrdersTransactions = new System.Windows.Forms.DataGridView();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrdersTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSalesOrder
            // 
            this.lstSalesOrder.FormattingEnabled = true;
            this.lstSalesOrder.Location = new System.Drawing.Point(12, 41);
            this.lstSalesOrder.Name = "lstSalesOrder";
            this.lstSalesOrder.Size = new System.Drawing.Size(176, 277);
            this.lstSalesOrder.TabIndex = 3;
            this.lstSalesOrder.SelectedIndexChanged += new System.EventHandler(this.lstSalesOrder_SelectedIndexChanged);
            // 
            // dgvSalesOrdersTransactions
            // 
            this.dgvSalesOrdersTransactions.AllowUserToAddRows = false;
            this.dgvSalesOrdersTransactions.AllowUserToDeleteRows = false;
            this.dgvSalesOrdersTransactions.AllowUserToResizeColumns = false;
            this.dgvSalesOrdersTransactions.AllowUserToResizeRows = false;
            this.dgvSalesOrdersTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalesOrdersTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalesOrdersTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrdersTransactions.Location = new System.Drawing.Point(194, 15);
            this.dgvSalesOrdersTransactions.Name = "dgvSalesOrdersTransactions";
            this.dgvSalesOrdersTransactions.ReadOnly = true;
            this.dgvSalesOrdersTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrdersTransactions.Size = new System.Drawing.Size(428, 303);
            this.dgvSalesOrdersTransactions.TabIndex = 2;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(94, 15);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(94, 21);
            this.cmbCustomers.TabIndex = 4;
            this.cmbCustomers.TextChanged += new System.EventHandler(this.cmbCustomers_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 13);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter Customer";
            // 
            // View_Sales_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lstSalesOrder);
            this.Controls.Add(this.dgvSalesOrdersTransactions);
            this.Name = "View_Sales_Order";
            this.Text = "View_Sales_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrdersTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSalesOrder;
        private System.Windows.Forms.DataGridView dgvSalesOrdersTransactions;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblFilter;

    }
}