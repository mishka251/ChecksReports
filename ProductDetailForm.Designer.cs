using System.ComponentModel;

namespace CheckReport
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LblVendorCode = new System.Windows.Forms.Label();
            this.TbVendorCode = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.NuPrice = new System.Windows.Forms.NumericUpDown();
            this.NuCount = new System.Windows.Forms.NumericUpDown();
            this.LblCount = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.NuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NuCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVendorCode
            // 
            this.LblVendorCode.Location = new System.Drawing.Point(27, 64);
            this.LblVendorCode.Name = "LblVendorCode";
            this.LblVendorCode.Size = new System.Drawing.Size(80, 32);
            this.LblVendorCode.TabIndex = 0;
            this.LblVendorCode.Text = "Артикул";
            // 
            // TbVendorCode
            // 
            this.TbVendorCode.Location = new System.Drawing.Point(188, 66);
            this.TbVendorCode.Name = "TbVendorCode";
            this.TbVendorCode.Size = new System.Drawing.Size(176, 20);
            this.TbVendorCode.TabIndex = 1;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(188, 121);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(176, 20);
            this.TbName.TabIndex = 3;
            // 
            // LblName
            // 
            this.LblName.Location = new System.Drawing.Point(27, 119);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(80, 32);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Название";
            // 
            // LblPrice
            // 
            this.LblPrice.Location = new System.Drawing.Point(26, 158);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(98, 38);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = "Цена";
            // 
            // NuPrice
            // 
            this.NuPrice.Location = new System.Drawing.Point(175, 165);
            this.NuPrice.Name = "NuPrice";
            this.NuPrice.Size = new System.Drawing.Size(188, 20);
            this.NuPrice.TabIndex = 5;
            // 
            // NuCount
            // 
            this.NuCount.Location = new System.Drawing.Point(176, 209);
            this.NuCount.Name = "NuCount";
            this.NuCount.Size = new System.Drawing.Size(188, 20);
            this.NuCount.TabIndex = 7;
            // 
            // LblCount
            // 
            this.LblCount.Location = new System.Drawing.Point(27, 202);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(98, 38);
            this.LblCount.TabIndex = 6;
            this.LblCount.Text = "Количество";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(26, 310);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(118, 32);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "Сохранить";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(230, 302);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 39);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.NuCount);
            this.Controls.Add(this.NuPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.TbVendorCode);
            this.Controls.Add(this.LblVendorCode);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize) (this.NuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NuCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.NumericUpDown NuCount;

        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.NumericUpDown NuPrice;

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label LblName;

        private System.Windows.Forms.Label LblVendorCode;
        private System.Windows.Forms.TextBox TbVendorCode;

        #endregion
    }
}