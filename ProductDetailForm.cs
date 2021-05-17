using System;
using System.Windows.Forms;

namespace CheckReport
{
    public partial class ProductDetailForm : Form
    {
        private PostgresDataBaseContext db;
        private Product product = null;
        public ProductDetailForm(PostgresDataBaseContext db, Product product=null)
        {
            this.db = db;
            InitializeComponent();
            this.product = product;
            if (product != null)
            {
                this.TbVendorCode.Text = product.VendorCode;
                this.TbName.Text = product.Name;
                this.NuCount.Value = product.Count;
                this.NuPrice.Value = product.Price;
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.product == null)
            {
                this.product = new Product();
                db.Products.Add(this.product);
            }

            this.product.VendorCode = this.TbVendorCode.Text;
            this.product.Name = this.TbName.Text;
            this.product.Price = this.NuPrice.Value;
            this.product.Count = (int)this.NuCount.Value;

            db.SaveChanges();
        }
    }
}