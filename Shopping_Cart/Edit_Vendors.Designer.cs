namespace Shopping_Cart
{
    partial class Edit_Vendors
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
            this.lstVendors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVendors
            // 
            this.lstVendors.FormattingEnabled = true;
            this.lstVendors.Location = new System.Drawing.Point(13, 13);
            this.lstVendors.Name = "lstVendors";
            this.lstVendors.Size = new System.Drawing.Size(207, 238);
            this.lstVendors.TabIndex = 0;
            this.lstVendors.SelectedIndexChanged += new System.EventHandler(this.lstVendors_SelectedIndexChanged);
            this.lstVendors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVendors_MouseDoubleClick);
            // 
            // Edit_Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 261);
            this.Controls.Add(this.lstVendors);
            this.Name = "Edit_Vendors";
            this.Text = "Edit_Vendors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendors;

    }
}