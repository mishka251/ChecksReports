namespace CheckReport
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProducts
            // 
            this.BtnProducts.Location = new System.Drawing.Point(39, 67);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(172, 64);
            this.BtnProducts.TabIndex = 0;
            this.BtnProducts.Text = "Товары";
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(36, 156);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(174, 54);
            this.BtnCustomers.TabIndex = 1;
            this.BtnCustomers.Text = "Заказчики";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.Location = new System.Drawing.Point(47, 244);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(162, 61);
            this.BtnOrders.TabIndex = 2;
            this.BtnOrders.Text = "Заказы";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnProducts);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BtnOrders;

        private System.Windows.Forms.Button BtnCustomers;

        private System.Windows.Forms.Button BtnProducts;

        #endregion
    }
}