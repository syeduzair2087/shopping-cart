namespace Shopping_Cart
{
    partial class Products
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblFilterVendor = new System.Windows.Forms.Label();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnEditCategories = new System.Windows.Forms.Button();
            this.btnEditVendors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(528, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(114, 23);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
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
            this.dgvProducts.Location = new System.Drawing.Point(13, 102);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(629, 326);
            this.dgvProducts.TabIndex = 7;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProducts_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(88, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(88, 37);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 2;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.cmbVendor_SelectedIndexChanged);
            this.cmbVendor.TextChanged += new System.EventHandler(this.cmbVendor_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(13, 13);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(69, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter Product";
            // 
            // lblFilterVendor
            // 
            this.lblFilterVendor.AutoSize = true;
            this.lblFilterVendor.Location = new System.Drawing.Point(13, 40);
            this.lblFilterVendor.Name = "lblFilterVendor";
            this.lblFilterVendor.Size = new System.Drawing.Size(66, 13);
            this.lblFilterVendor.TabIndex = 5;
            this.lblFilterVendor.Text = "Filter Vendor";
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Location = new System.Drawing.Point(13, 67);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(74, 13);
            this.lblFilterCategory.TabIndex = 7;
            this.lblFilterCategory.Text = "Filter Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(88, 64);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.TextChanged += new System.EventHandler(this.cmbCategory_TextChanged);
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.Location = new System.Drawing.Point(528, 34);
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Size = new System.Drawing.Size(114, 23);
            this.btnEditCategories.TabIndex = 5;
            this.btnEditCategories.Text = "Edit Categories";
            this.btnEditCategories.UseVisualStyleBackColor = true;
            this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
            // 
            // btnEditVendors
            // 
            this.btnEditVendors.Location = new System.Drawing.Point(528, 61);
            this.btnEditVendors.Name = "btnEditVendors";
            this.btnEditVendors.Size = new System.Drawing.Size(114, 23);
            this.btnEditVendors.TabIndex = 6;
            this.btnEditVendors.Text = "Edit Vendors";
            this.btnEditVendors.UseVisualStyleBackColor = true;
            this.btnEditVendors.Click += new System.EventHandler(this.btnEditVendors_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 440);
            this.Controls.Add(this.btnEditVendors);
            this.Controls.Add(this.btnEditCategories);
            this.Controls.Add(this.lblFilterCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblFilterVendor);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblFilterVendor;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnEditCategories;
        private System.Windows.Forms.Button btnEditVendors;
    }
}