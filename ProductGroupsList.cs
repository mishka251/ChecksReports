using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CheckReport
{
    public partial class ProductGroupsList : Form
    {
        
        private PostgresDataBaseContext db;
        
        public ProductGroupsList(PostgresDataBaseContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProductGroupDetailForm add = new ProductGroupDetailForm(this.db);
            add.Show();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку");
                return;
            }

            var selectedId = this.dataGridView1.SelectedRows[0].Cells["Id"].Value;
            ProductGroup selected = db.ProductGroups.Find(selectedId);
            ProductGroupDetailForm add = new ProductGroupDetailForm(this.db, selected);
            add.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.dataGridView1.SelectedRows)
            {
                var selectedId = selectedRow.Cells["Id"].Value;
                ProductGroup selected = db.ProductGroups.Find(selectedId);
                db.ProductGroups.Remove(selected);
            }

            db.SaveChanges();
        }

        private void TradeDepartmentsList_Load(object sender, EventArgs e)
        {
            db.ProductGroups.Load();
            this.dataGridView1.DataSource = db.ProductGroups.Local.ToBindingList();
        }
    }
}