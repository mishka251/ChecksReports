using System;
using System.Windows.Forms;

namespace CheckReport
{
    public partial class ProductGroupDetailForm : Form
    {
        private PostgresDataBaseContext db;
        private ProductGroup group = null;
        public ProductGroupDetailForm(PostgresDataBaseContext db, ProductGroup group=null)
        {
            InitializeComponent();
            this.db = db;
            this.group = group;
            if (group != null)
            {
                this.TbName.Text = this.group.Name;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.group == null)
            {
                this.group = new ProductGroup();
                db.ProductGroups.Add(this.group);
            }

            this.group.Name = this.TbName.Text;

            db.SaveChanges();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}