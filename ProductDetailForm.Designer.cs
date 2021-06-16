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
            this.TbName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.NuPriceRetail = new System.Windows.Forms.NumericUpDown();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NuPriceWholesale = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.NuPriceRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NuPriceWholesale)).BeginInit();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(132, 26);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(176, 20);
            this.TbName.TabIndex = 3;
            // 
            // LblName
            // 
            this.LblName.Location = new System.Drawing.Point(26, 29);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(80, 32);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Название";
            // 
            // LblPrice
            // 
            this.LblPrice.Location = new System.Drawing.Point(8, 145);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(98, 38);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = " Цена розиначная";
            // 
            // NuPriceRetail
            // 
            this.NuPriceRetail.DecimalPlaces = 2;
            this.NuPriceRetail.Location = new System.Drawing.Point(130, 145);
            this.NuPriceRetail.Maximum = new decimal(new int[] {-1530494976, 232830, 0, 0});
            this.NuPriceRetail.Name = "NuPriceRetail";
            this.NuPriceRetail.Size = new System.Drawing.Size(188, 20);
            this.NuPriceRetail.TabIndex = 5;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(25, 362);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(118, 32);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "Сохранить";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(229, 354);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 39);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbGroup
            // 
            this.CbGroup.FormattingEnabled = true;
            this.CbGroup.Location = new System.Drawing.Point(133, 69);
            this.CbGroup.Name = "CbGroup";
            this.CbGroup.Size = new System.Drawing.Size(174, 21);
            this.CbGroup.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Группа товара";
            // 
            // CbDepartment
            // 
            this.CbDepartment.FormattingEnabled = true;
            this.CbDepartment.Location = new System.Drawing.Point(133, 103);
            this.CbDepartment.Name = "CbDepartment";
            this.CbDepartment.Size = new System.Drawing.Size(173, 21);
            this.CbDepartment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Отдел товара";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Еденица измерения";
            // 
            // NuPriceWholesale
            // 
            this.NuPriceWholesale.DecimalPlaces = 2;
            this.NuPriceWholesale.Location = new System.Drawing.Point(130, 171);
            this.NuPriceWholesale.Maximum = new decimal(new int[] {-1530494976, 232830, 0, 0});
            this.NuPriceWholesale.Name = "NuPriceWholesale";
            this.NuPriceWholesale.Size = new System.Drawing.Size(188, 20);
            this.NuPriceWholesale.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена оптовая";
            // 
            // TbCountry
            // 
            this.TbCountry.Location = new System.Drawing.Point(133, 297);
            this.TbCountry.Name = "TbCountry";
            this.TbCountry.Size = new System.Drawing.Size(156, 20);
            this.TbCountry.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Страна";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {"кг", "шт", "м3", "м2", "м", "г", "л", "т"});
            this.cbUnit.Location = new System.Drawing.Point(129, 249);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(159, 21);
            this.cbUnit.TabIndex = 20;
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.TbCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NuPriceWholesale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbGroup);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.NuPriceRetail);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.LblName);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize) (this.NuPriceRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NuPriceWholesale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbUnit;

        private System.Windows.Forms.NumericUpDown NuPriceWholesale;
        private System.Windows.Forms.TextBox TbCountry;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbDepartment;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox CbGroup;

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.NumericUpDown NuPriceRetail;

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label LblName;

        #endregion
    }
}