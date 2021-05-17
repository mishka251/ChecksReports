using System.ComponentModel;

namespace CheckReport
{
    partial class CustomerDetailForm
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
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbFirstName
            // 
            this.TbFirstName.Location = new System.Drawing.Point(229, 54);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(138, 20);
            this.TbFirstName.TabIndex = 0;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(229, 91);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(137, 20);
            this.TbLastName.TabIndex = 1;
            // 
            // LblFirstName
            // 
            this.LblFirstName.Location = new System.Drawing.Point(96, 52);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(97, 21);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "Имя";
            // 
            // LblLastName
            // 
            this.LblLastName.Location = new System.Drawing.Point(96, 91);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(109, 29);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Фамилия";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(291, 212);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 39);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(87, 220);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(118, 32);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "Сохранить";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.TbFirstName);
            this.Name = "CustomerDetailForm";
            this.Text = "CustomerDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;

        private System.Windows.Forms.Label LblLastName;

        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label LblFirstName;

        #endregion
    }
}