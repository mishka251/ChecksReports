using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CheckReport
{
    public partial class TradeDepartmentsList : Form
    {
        
        private PostgresDataBaseContext db;
        
        public TradeDepartmentsList(PostgresDataBaseContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TradeDepartmentDetailForm add = new TradeDepartmentDetailForm(this.db);
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
            TradeDepartment selected = db.TradeDepartments.Find(selectedId);
            TradeDepartmentDetailForm add = new TradeDepartmentDetailForm(this.db, selected);
            add.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.dataGridView1.SelectedRows)
            {
                var selectedId = selectedRow.Cells["Id"].Value;
                TradeDepartment selected = db.TradeDepartments.Find(selectedId);
                db.TradeDepartments.Remove(selected);
            }

            db.SaveChanges();
        }

        private void TradeDepartmentsList_Load(object sender, EventArgs e)
        {
            db.TradeDepartments.Load();
            this.dataGridView1.DataSource = db.TradeDepartments.Local.ToBindingList();
        }
    }
}