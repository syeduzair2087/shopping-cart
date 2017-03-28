namespace Shopping_Cart
{
    partial class Edit_Vendor_By_ID
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
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.Location = new System.Drawing.Point(12, 41);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(259, 52);
            this.btnUpdateVendor.TabIndex = 17;
            this.btnUpdateVendor.Text = "Update Vendor";
            this.btnUpdateVendor.UseVisualStyleBackColor = true;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(123, 10);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(148, 20);
            this.txtVendorName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Enter Vendor Name";
            // 
            // Edit_Vendor_By_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblName);
            this.Name = "Edit_Vendor_By_ID";
            this.Text = "Edit_Vendor_By_ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateVendor;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label lblName;
    }
}