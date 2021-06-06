using System;
using System.ComponentModel;
using System.Linq;
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
            
            BindingList<ProductGroup>
                groups = new BindingList<ProductGroup>(this.db.ProductGroups.ToList());
            
            CbGroup.ValueMember = null;
            // CbGroup.DisplayMember = "Name";
            CbGroup.DataSource = groups;
            
            BindingList<TradeDepartment>
                departments = new BindingList<TradeDepartment>(this.db.TradeDepartments.ToList());
            
            CbDepartment.ValueMember = null;
            // CbDepartment.DisplayMember = "Name";
            CbDepartment.DataSource = departments;
            
            this.product = product;
            if (product != null)
            {
                this.TbName.Text = product.Name;
                // this.NuCount.Value = product.Count;
                this.NuPriceRetail.Value = product.RetailPrice;
                this.NuPriceWholesale.Value = product.WholesalePrice;
                this.CbGroup.SelectedItem = product.Group;
                this.CbDepartment.SelectedItem = product.Department;
                this.TbUnit.Text = product.Unit;
                this.TbCountry.Text = product.Country;
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

            // this.product.VendorCode = this.TbVendorCode.Text;
            this.product.Name = this.TbName.Text;
            this.product.RetailPrice = this.NuPriceRetail.Value;
            this.product.WholesalePrice = this.NuPriceWholesale.Value;
            this.product.Group = (ProductGroup)this.CbGroup.SelectedItem;
            this.product.Department = (TradeDepartment)this.CbDepartment.SelectedItem;
            this.product.Unit = this.TbUnit.Text;
            this.product.Country = this.TbCountry.Text;
            // this.product.Count = (int)this.NuCount.Value;

            db.SaveChanges();
            this.Close();
        }
    }
}