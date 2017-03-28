namespace Shopping_Cart
{
    partial class Generate_Purchase_Order
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
            this.dgvPurchaseOrdersTransactions = new System.Windows.Forms.DataGridView();
            this.lstPurchaseOrder = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrdersTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseOrdersTransactions
            // 
            this.dgvPurchaseOrdersTransactions.AllowUserToAddRows = false;
            this.dgvPurchaseOrdersTransactions.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrdersTransactions.AllowUserToResizeColumns = false;
            this.dgvPurchaseOrdersTransactions.AllowUserToResizeRows = false;
            this.dgvPurchaseOrdersTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPurchaseOrdersTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPurchaseOrdersTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrdersTransactions.Location = new System.Drawing.Point(195, 17);
            this.dgvPurchaseOrdersTransactions.Name = "dgvPurchaseOrdersTransactions";
            this.dgvPurchaseOrdersTransactions.ReadOnly = true;
            this.dgvPurchaseOrdersTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrdersTransactions.Size = new System.Drawing.Size(428, 303);
            this.dgvPurchaseOrdersTransactions.TabIndex = 0;
            this.dgvPurchaseOrdersTransactions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrdersTransactions_CellDoubleClick);
            // 
            // lstPurchaseOrder
            // 
            this.lstPurchaseOrder.FormattingEnabled = true;
            this.lstPurchaseOrder.Location = new System.Drawing.Point(13, 17);
            this.lstPurchaseOrder.Name = "lstPurchaseOrder";
            this.lstPurchaseOrder.Size = new System.Drawing.Size(176, 303);
            this.lstPurchaseOrder.TabIndex = 1;
            this.lstPurchaseOrder.Click += new System.EventHandler(this.lstPurchaseOrder_Click);
            this.lstPurchaseOrder.SelectedIndexChanged += new System.EventHandler(this.lstPurchaseOrder_SelectedIndexChanged);
            // 
            // Generate_Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.lstPurchaseOrder);
            this.Controls.Add(this.dgvPurchaseOrdersTransactions);
            this.Name = "Generate_Purchase_Order";
            this.Text = "Generate_Purchase_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrdersTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchaseOrdersTransactions;
        private System.Windows.Forms.ListBox lstPurchaseOrder;
    }
}