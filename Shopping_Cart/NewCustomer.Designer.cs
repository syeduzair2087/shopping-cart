namespace Shopping_Cart
{
    partial class NewCustomer
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
            this.lblNewCustomerName = new System.Windows.Forms.Label();
            this.txtNewCustomerName = new System.Windows.Forms.TextBox();
            this.txtNewCustomerContact = new System.Windows.Forms.TextBox();
            this.lblNewCustomerContact = new System.Windows.Forms.Label();
            this.lblNewCustomerAddress = new System.Windows.Forms.Label();
            this.txtNewCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewCustomerName
            // 
            this.lblNewCustomerName.AutoSize = true;
            this.lblNewCustomerName.Location = new System.Drawing.Point(13, 13);
            this.lblNewCustomerName.Name = "lblNewCustomerName";
            this.lblNewCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblNewCustomerName.TabIndex = 0;
            this.lblNewCustomerName.Text = "Customer Name";
            // 
            // txtNewCustomerName
            // 
            this.txtNewCustomerName.Location = new System.Drawing.Point(101, 10);
            this.txtNewCustomerName.Name = "txtNewCustomerName";
            this.txtNewCustomerName.Size = new System.Drawing.Size(171, 20);
            this.txtNewCustomerName.TabIndex = 1;
            // 
            // txtNewCustomerContact
            // 
            this.txtNewCustomerContact.Location = new System.Drawing.Point(101, 36);
            this.txtNewCustomerContact.Name = "txtNewCustomerContact";
            this.txtNewCustomerContact.Size = new System.Drawing.Size(171, 20);
            this.txtNewCustomerContact.TabIndex = 2;
            // 
            // lblNewCustomerContact
            // 
            this.lblNewCustomerContact.AutoSize = true;
            this.lblNewCustomerContact.Location = new System.Drawing.Point(13, 39);
            this.lblNewCustomerContact.Name = "lblNewCustomerContact";
            this.lblNewCustomerContact.Size = new System.Drawing.Size(64, 13);
            this.lblNewCustomerContact.TabIndex = 2;
            this.lblNewCustomerContact.Text = "Contact No.";
            // 
            // lblNewCustomerAddress
            // 
            this.lblNewCustomerAddress.AutoSize = true;
            this.lblNewCustomerAddress.Location = new System.Drawing.Point(13, 65);
            this.lblNewCustomerAddress.Name = "lblNewCustomerAddress";
            this.lblNewCustomerAddress.Size = new System.Drawing.Size(45, 13);
            this.lblNewCustomerAddress.TabIndex = 4;
            this.lblNewCustomerAddress.Text = "Address";
            // 
            // txtNewCustomerAddress
            // 
            this.txtNewCustomerAddress.Location = new System.Drawing.Point(101, 62);
            this.txtNewCustomerAddress.Name = "txtNewCustomerAddress";
            this.txtNewCustomerAddress.Size = new System.Drawing.Size(171, 49);
            this.txtNewCustomerAddress.TabIndex = 3;
            this.txtNewCustomerAddress.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 117);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(260, 46);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNewCustomerAddress);
            this.Controls.Add(this.lblNewCustomerAddress);
            this.Controls.Add(this.txtNewCustomerContact);
            this.Controls.Add(this.lblNewCustomerContact);
            this.Controls.Add(this.txtNewCustomerName);
            this.Controls.Add(this.lblNewCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewCustomerName;
        private System.Windows.Forms.TextBox txtNewCustomerName;
        private System.Windows.Forms.TextBox txtNewCustomerContact;
        private System.Windows.Forms.Label lblNewCustomerContact;
        private System.Windows.Forms.Label lblNewCustomerAddress;
        private System.Windows.Forms.RichTextBox txtNewCustomerAddress;
        private System.Windows.Forms.Button btnSubmit;
    }
}