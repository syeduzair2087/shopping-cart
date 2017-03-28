namespace Shopping_Cart
{
    partial class View_Receive_Order
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lstReceiveOrder = new System.Windows.Forms.ListBox();
            this.dgvReceiveOrdersTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveOrdersTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(64, 13);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter Admin.";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(94, 15);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(94, 21);
            this.cmbUsers.TabIndex = 8;
            this.cmbUsers.TextChanged += new System.EventHandler(this.cmbUsers_TextChanged);
            // 
            // lstReceiveOrder
            // 
            this.lstReceiveOrder.FormattingEnabled = true;
            this.lstReceiveOrder.Location = new System.Drawing.Point(12, 41);
            this.lstReceiveOrder.Name = "lstReceiveOrder";
            this.lstReceiveOrder.Size = new System.Drawing.Size(176, 277);
            this.lstReceiveOrder.TabIndex = 7;
            this.lstReceiveOrder.SelectedIndexChanged += new System.EventHandler(this.lstReceiveOrder_SelectedIndexChanged);
            // 
            // dgvReceiveOrdersTransactions
            // 
            this.dgvReceiveOrdersTransactions.AllowUserToAddRows = false;
            this.dgvReceiveOrdersTransactions.AllowUserToDeleteRows = false;
            this.dgvReceiveOrdersTransactions.AllowUserToResizeColumns = false;
            this.dgvReceiveOrdersTransactions.AllowUserToResizeRows = false;
            this.dgvReceiveOrdersTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReceiveOrdersTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceiveOrdersTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveOrdersTransactions.Location = new System.Drawing.Point(194, 15);
            this.dgvReceiveOrdersTransactions.Name = "dgvReceiveOrdersTransactions";
            this.dgvReceiveOrdersTransactions.ReadOnly = true;
            this.dgvReceiveOrdersTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiveOrdersTransactions.Size = new System.Drawing.Size(428, 303);
            this.dgvReceiveOrdersTransactions.TabIndex = 6;
            // 
            // View_Receive_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.lstReceiveOrder);
            this.Controls.Add(this.dgvReceiveOrdersTransactions);
            this.Name = "View_Receive_Order";
            this.Text = "View_Receive_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveOrdersTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.ListBox lstReceiveOrder;
        private System.Windows.Forms.DataGridView dgvReceiveOrdersTransactions;

    }
}