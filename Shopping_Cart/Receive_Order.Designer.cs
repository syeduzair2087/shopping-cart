namespace Shopping_Cart
{
    partial class Receive_Order
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
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblFilterVendor = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvReceivedProducts = new System.Windows.Forms.DataGridView();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Location = new System.Drawing.Point(12, 63);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(74, 13);
            this.lblFilterCategory.TabIndex = 14;
            this.lblFilterCategory.Text = "Filter Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(87, 60);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
            // 
            // lblFilterVendor
            // 
            this.lblFilterVendor.AutoSize = true;
            this.lblFilterVendor.Location = new System.Drawing.Point(12, 36);
            this.lblFilterVendor.Name = "lblFilterVendor";
            this.lblFilterVendor.Size = new System.Drawing.Size(66, 13);
            this.lblFilterVendor.TabIndex = 12;
            this.lblFilterVendor.Text = "Filter Vendor";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 9);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(69, 13);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Filter Product";
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(87, 33);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 10;
            this.cmbVendor.TextChanged += new System.EventHandler(this.cmbVendor_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.Location = new System.Drawing.Point(12, 98);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(294, 326);
            this.dgvProducts.TabIndex = 8;
            // 
            // dgvReceivedProducts
            // 
            this.dgvReceivedProducts.AllowUserToAddRows = false;
            this.dgvReceivedProducts.AllowUserToDeleteRows = false;
            this.dgvReceivedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReceivedProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceivedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivedProducts.Location = new System.Drawing.Point(322, 98);
            this.dgvReceivedProducts.MultiSelect = false;
            this.dgvReceivedProducts.Name = "dgvReceivedProducts";
            this.dgvReceivedProducts.ReadOnly = true;
            this.dgvReceivedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivedProducts.Size = new System.Drawing.Size(378, 326);
            this.dgvReceivedProducts.TabIndex = 15;
            this.dgvReceivedProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvReceivedProducts_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(504, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 13);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Enter Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(579, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(504, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 13);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Enter Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(579, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(579, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Receive_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 434);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dgvReceivedProducts);
            this.Controls.Add(this.lblFilterCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblFilterVendor);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Receive_Order";
            this.Text = "Receive_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblFilterVendor;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvReceivedProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
    }
}