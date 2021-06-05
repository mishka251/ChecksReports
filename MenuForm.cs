using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CheckReport
{
    public partial class MenuForm : Form
    {
        private PostgresDataBaseContext db;
        public MenuForm()
        {
            this.db = new PostgresDataBaseContext();
            
            db.ProductsInOrders.Load();
            db.Customers.Load();
            db.Orders.Load();
            db.Products.Load();
            
            InitializeComponent();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm(db);
            pf.Show();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomersList customers = new CustomersList(this.db);
            customers.Show();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            OrdersList orders = new OrdersList(this.db);
            orders.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductGroupsList orders = new ProductGroupsList(this.db);
            orders.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TradeDepartmentsList orders = new TradeDepartmentsList(this.db);
            orders.Show();
        }
    }
}