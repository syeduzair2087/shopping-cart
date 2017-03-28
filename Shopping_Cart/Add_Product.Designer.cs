namespace Shopping_Cart
{
    partial class Add_Product
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(90, 13);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(182, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(90, 41);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(182, 21);
            this.cmbVendor.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 3;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescription.Location = new System.Drawing.Point(90, 121);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(182, 126);
            this.rtxtDescription.TabIndex = 5;
            this.rtxtDescription.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(12, 44);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 6;
            this.lblVendor.Text = "Vendor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(13, 253);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(259, 52);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(12, 98);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(99, 13);
            this.lblProfit.TabIndex = 12;
            this.lblProfit.Text = "Profit                    %";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(119, 95);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(153, 20);
            this.txtProfit.TabIndex = 4;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(13, 253);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(259, 52);
            this.btnUpdateProduct.TabIndex = 6;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.cmbCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Product";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Button btnUpdateProduct;

    }
}