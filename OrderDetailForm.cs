﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CheckReport
{
    public partial class OrderDetailForm : Form
    {
        private PostgresDataBaseContext db;
        private Order order;

        public OrderDetailForm(PostgresDataBaseContext db, Order order = null)
        {
            this.order = order;
            this.db = db;


            InitializeComponent();

            this.db.Customers.Load();
            this.comboBox1.Items.AddRange(this.db.Customers.ToArray());

            this.db.Products.Load();
            var products = this.db.Products;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            foreach (var product in products)
            {
                comboSource.Add(product.Id, product.Name);
            }

            (dataGridView1.Columns["ProductType"] as DataGridViewComboBoxColumn).DataSource =
                new BindingSource(comboSource, null);
            
            if (order != null)
            {
                this.dateTimePicker1.Value = order.DateTime;
                this.comboBox1.SelectedItem = order.Customer;

                foreach (var product in order?.ProductInOrders)
                {
                    dataGridView1.Rows.Add(product.Product.Id, product.ProductCount);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.order == null)
            {
                this.order = new Order();
                db.Orders.Add(this.order);
            }

            this.order.Customer = this.comboBox1.SelectedItem as Customer;
            this.order.DateTime = this.dateTimePicker1.Value;
            this.order.ProductInOrders?.Clear();

            this.order.ProductInOrders = new List<ProductInOrder>();

            for (int row = 0; row < this.dataGridView1.RowCount - 1; row++)
            {
                object _count = this.dataGridView1[1, row].Value;
                int count;
                if (_count is int)
                {
                    count = (int)_count;
                }
                else
                {
                    count = int.Parse(_count as string);
                }
                
                int productId = (int)(this.dataGridView1[0, row] as DataGridViewComboBoxCell).Value;
                Product product = this.db.Products.Find(productId);
                this.order.ProductInOrders.Add(new ProductInOrder(){ProductCount = count, Product = product, Order = this.order});
            }
            

            db.SaveChanges();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var val = this.dataGridView1[0, 0].Value;
            var items = (this.dataGridView1.Columns[0] as DataGridViewComboBoxColumn).Items;
            MessageBox.Show($"col: {e.ColumnIndex}, row: {e.RowIndex}, context {e.Context}");
        }
    }
}