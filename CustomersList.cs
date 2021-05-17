using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CheckReport
{
    public partial class CustomersList : Form
    {
        private PostgresDataBaseContext db;
        
        public CustomersList(PostgresDataBaseContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        
        private void CustomersList_Load(object sender, EventArgs e)
        {
            db.Customers.Load();
            this.dataGridView1.DataSource = db.Customers.Local.ToBindingList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CustomerDetailForm add = new CustomerDetailForm(this.db);
            add.Show();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            var selectedId = this.dataGridView1.SelectedRows[0].Cells["Id"].Value;
            Customer selected = db.Customers.Find(selectedId);
            CustomerDetailForm add = new CustomerDetailForm(this.db,selected);
            add.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedId = this.dataGridView1.SelectedRows[0].Cells["Id"].Value;
            Customer selected = db.Customers.Find(selectedId);
            db.Customers.Remove(selected);
            db.SaveChanges();
        }
    }
}