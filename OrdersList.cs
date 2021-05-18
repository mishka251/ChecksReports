using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CheckReport
{
    public partial class OrdersList : Form
    {
        private PostgresDataBaseContext db;
        public OrdersList(PostgresDataBaseContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            db.Orders.Load();
            this.dataGridView1.DataSource = db.Orders.Local.ToBindingList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OrderDetailForm add = new OrderDetailForm(this.db);
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
            Order selected = db.Orders.Find(selectedId);
            OrderDetailForm change = new OrderDetailForm(this.db,selected);
            change.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in this.dataGridView1.SelectedRows)
            {
                var selectedId = selectedRow.Cells["Id"].Value;
                Order selected = db.Orders.Find(selectedId);
                db.Orders.Remove(selected);
            }

            db.SaveChanges();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            var dialogResult =  saveFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes)
            {
                return;
            }

            StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
            foreach (var order in this.db.Orders)
            {
                order.Save(writer);
            }
            writer.Close();
        }
    }
}