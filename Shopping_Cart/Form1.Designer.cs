namespace Shopping_Cart
{
    partial class Form1
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
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnRO = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnViewReceiveOrder = new System.Windows.Forms.Button();
            this.btnViewSalesOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(20, 20);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(130, 20);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "Select User Type";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Customer",
            "Administrator"});
            this.cmbUserType.Location = new System.Drawing.Point(162, 15);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(244, 28);
            this.cmbUserType.TabIndex = 1;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(162, 57);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(244, 28);
            this.cmbUserName.TabIndex = 2;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 62);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(138, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Select User Name";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Enabled = false;
            this.btnNewUser.Location = new System.Drawing.Point(18, 372);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(390, 86);
            this.btnNewUser.TabIndex = 9;
            this.btnNewUser.Text = "Register New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnShopping
            // 
            this.btnShopping.Enabled = false;
            this.btnShopping.Location = new System.Drawing.Point(18, 114);
            this.btnShopping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(189, 77);
            this.btnShopping.TabIndex = 3;
            this.btnShopping.Text = "Let\'s Do Some Shopping!";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // btnPO
            // 
            this.btnPO.Enabled = false;
            this.btnPO.Location = new System.Drawing.Point(18, 200);
            this.btnPO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(189, 77);
            this.btnPO.TabIndex = 5;
            this.btnPO.Text = "View Purchase Order";
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnRO
            // 
            this.btnRO.Enabled = false;
            this.btnRO.Location = new System.Drawing.Point(219, 200);
            this.btnRO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRO.Name = "btnRO";
            this.btnRO.Size = new System.Drawing.Size(189, 77);
            this.btnRO.TabIndex = 6;
            this.btnRO.Text = "Create Receive Order";
            this.btnRO.UseVisualStyleBackColor = true;
            this.btnRO.Click += new System.EventHandler(this.btnRO_Click);
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(219, 114);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(189, 77);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Products";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnViewReceiveOrder
            // 
            this.btnViewReceiveOrder.Enabled = false;
            this.btnViewReceiveOrder.Location = new System.Drawing.Point(18, 286);
            this.btnViewReceiveOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewReceiveOrder.Name = "btnViewReceiveOrder";
            this.btnViewReceiveOrder.Size = new System.Drawing.Size(189, 77);
            this.btnViewReceiveOrder.TabIndex = 7;
            this.btnViewReceiveOrder.Text = "View Receive Order";
            this.btnViewReceiveOrder.UseVisualStyleBackColor = true;
            this.btnViewReceiveOrder.Click += new System.EventHandler(this.btnViewReceiveOrder_Click);
            // 
            // btnViewSalesOrder
            // 
            this.btnViewSalesOrder.Enabled = false;
            this.btnViewSalesOrder.Location = new System.Drawing.Point(219, 288);
            this.btnViewSalesOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewSalesOrder.Name = "btnViewSalesOrder";
            this.btnViewSalesOrder.Size = new System.Drawing.Size(189, 75);
            this.btnViewSalesOrder.TabIndex = 8;
            this.btnViewSalesOrder.Text = "View Sales Order";
            this.btnViewSalesOrder.UseVisualStyleBackColor = true;
            this.btnViewSalesOrder.Click += new System.EventHandler(this.btnViewSalesOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 475);
            this.Controls.Add(this.btnViewSalesOrder);
            this.Controls.Add(this.btnViewReceiveOrder);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnRO);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.lblUserType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnRO;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnViewReceiveOrder;
        private System.Windows.Forms.Button btnViewSalesOrder;

    }
}

