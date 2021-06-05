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
            this.TbShortName = new System.Windows.Forms.TextBox();
            this.TbFullName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbINN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbOKPO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbKPP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPhoneNumber = new System.Windows.Forms.TextBox();
            this.CbTradeDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbShortName
            // 
            this.TbShortName.Location = new System.Drawing.Point(159, 31);
            this.TbShortName.Name = "TbShortName";
            this.TbShortName.Size = new System.Drawing.Size(138, 20);
            this.TbShortName.TabIndex = 0;
            // 
            // TbFullName
            // 
            this.TbFullName.Location = new System.Drawing.Point(159, 68);
            this.TbFullName.Name = "TbFullName";
            this.TbFullName.Size = new System.Drawing.Size(137, 20);
            this.TbFullName.TabIndex = 1;
            // 
            // LblFirstName
            // 
            this.LblFirstName.Location = new System.Drawing.Point(26, 29);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(97, 21);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "Псевдоним";
            // 
            // LblLastName
            // 
            this.LblLastName.Location = new System.Drawing.Point(26, 68);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(109, 29);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Полное название";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(179, 385);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(123, 39);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(26, 388);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(118, 32);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "Сохранить";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "ИНН";
            // 
            // TbINN
            // 
            this.TbINN.Location = new System.Drawing.Point(159, 108);
            this.TbINN.Name = "TbINN";
            this.TbINN.Size = new System.Drawing.Size(137, 20);
            this.TbINN.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ОКПО";
            // 
            // TbOKPO
            // 
            this.TbOKPO.Location = new System.Drawing.Point(160, 148);
            this.TbOKPO.Name = "TbOKPO";
            this.TbOKPO.Size = new System.Drawing.Size(137, 20);
            this.TbOKPO.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "КПП";
            // 
            // TbKPP
            // 
            this.TbKPP.Location = new System.Drawing.Point(160, 185);
            this.TbKPP.Name = "TbKPP";
            this.TbKPP.Size = new System.Drawing.Size(137, 20);
            this.TbKPP.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Адрес";
            // 
            // TbAdress
            // 
            this.TbAdress.Location = new System.Drawing.Point(159, 223);
            this.TbAdress.Name = "TbAdress";
            this.TbAdress.Size = new System.Drawing.Size(137, 20);
            this.TbAdress.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Телефонный номер";
            // 
            // TbPhoneNumber
            // 
            this.TbPhoneNumber.Location = new System.Drawing.Point(159, 261);
            this.TbPhoneNumber.Name = "TbPhoneNumber";
            this.TbPhoneNumber.Size = new System.Drawing.Size(137, 20);
            this.TbPhoneNumber.TabIndex = 20;
            // 
            // CbTradeDepartment
            // 
            this.CbTradeDepartment.FormattingEnabled = true;
            this.CbTradeDepartment.Location = new System.Drawing.Point(153, 297);
            this.CbTradeDepartment.Name = "CbTradeDepartment";
            this.CbTradeDepartment.Size = new System.Drawing.Size(142, 21);
            this.CbTradeDepartment.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(35, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Торговый отдел";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Статус";
            // 
            // TbStatus
            // 
            this.TbStatus.Location = new System.Drawing.Point(160, 343);
            this.TbStatus.Name = "TbStatus";
            this.TbStatus.Size = new System.Drawing.Size(137, 20);
            this.TbStatus.TabIndex = 24;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbTradeDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbKPP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbOKPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbINN);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TbFullName);
            this.Controls.Add(this.TbShortName);
            this.Name = "CustomerDetailForm";
            this.Text = "CustomerDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbStatus;

        private System.Windows.Forms.ComboBox CbTradeDepartment;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbPhoneNumber;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbAdress;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbINN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbOKPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbKPP;

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;

        private System.Windows.Forms.Label LblLastName;

        private System.Windows.Forms.TextBox TbShortName;
        private System.Windows.Forms.TextBox TbFullName;
        private System.Windows.Forms.Label LblFirstName;

        #endregion
    }
}