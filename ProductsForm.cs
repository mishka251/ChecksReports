using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckReport
{
    
    public partial class ProductsForm : Form
    {
        private PostgresDataBaseContext db;
        public ProductsForm(PostgresDataBaseContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            db.Products.Load();
            this.dataGridView1.DataSource = db.Products.Local.ToBindingList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var detail = new ProductDetailForm(db);
            detail.Show();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку");
                return;
            }
            var selectedId = this.dataGridView1.SelectedRows[0].Cells["Id"].Value;
            Product selected = db.Products.Find(selectedId);
            var detail = new ProductDetailForm(db, selected);
            detail.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.dataGridView1.SelectedRows)
            {
                var selectedId = selectedRow.Cells["Id"].Value;
                Product selected = db.Products.Find(selectedId);
                db.Products.Remove(selected);
            }

            db.SaveChanges();
        }
    }
}