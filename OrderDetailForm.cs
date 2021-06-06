using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.CbType.DataSource =
                Enum.GetValues(typeof(OrderType))
                    .Cast<OrderType>()
                    .Select(p => new {Name = Enum.GetName(typeof(OrderType), p), Value = (int) p})
                    .ToList();

            this.CbType.DisplayMember = "Name";
            this.CbType.ValueMember = "Name";


            this.db.Products.Load();
            var products = this.db.Products;
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            foreach (var product in products)
            {
                comboSource.Add(product.Id, product.Name);
            }

            (dataGridView1.Columns["ProductType"] as DataGridViewComboBoxColumn).DataSource =
                new BindingList<Product>(this.db.Products.ToList());
            (dataGridView1.Columns["ProductType"] as DataGridViewComboBoxColumn).ValueMember = "Id";
            (dataGridView1.Columns["ProductType"] as DataGridViewComboBoxColumn).DisplayMember = "Name";

            (dataGridView1.Columns["PriceType"] as DataGridViewComboBoxColumn).DataSource =
                Enum.GetValues(typeof(PriceType))
                    .Cast<PriceType>()
                    .Select(p => new {Name = Enum.GetName(typeof(PriceType), p), Value = (int) p})
                    .ToList();

            (dataGridView1.Columns["PriceType"] as DataGridViewComboBoxColumn).DisplayMember = "Name";
            (dataGridView1.Columns["PriceType"] as DataGridViewComboBoxColumn).ValueMember = "Name";


            if (order != null)
            {
                this.dateTimePicker1.Value = order.DateTime;
                this.comboBox1.SelectedItem = order.Customer;
                this.TbComment.Text = order.Comment;
                this.CbType.SelectedItem = order.Type.ToString();

                foreach (var product in order?.ProductInOrders)
                {
                    dataGridView1.Rows.Add(product.Product.Id, product.ProductCount, product.PriceType.ToString(),
                        product.Discount);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validate()
        {
            List<string> errors = new List<string>();
            List<int> productsIds = new List<int>();

            OrderType orderType = (OrderType) Enum.Parse(typeof(OrderType), CbType.SelectedValue.ToString());


            for (int row = 0; row < this.dataGridView1.RowCount - 1; row++)
            {
                int productId = (int) (this.dataGridView1[0, row] as DataGridViewComboBoxCell).Value;
                Product product = this.db.Products.Find(productId);

                if (productsIds.Contains(productId))
                {
                    errors.Add(
                        $"Строка {row + 1} товар {product} повтоярется с {productsIds.IndexOf(productId) + 1} строкой");
                }

                productsIds.Add(productId);

                object _count = this.dataGridView1[1, row].Value;
                int count;
                if (_count is int)
                {
                    count = (int) _count;
                }
                else
                {
                    if (!int.TryParse(_count as string, out count))
                    {
                        errors.Add($"Строка {row + 1} количество - не число");
                        continue;
                    }
                }

                int productCountWithoutThis = product.Count;
                if (this.order != null)
                {
                    var productInOrder = this.order.ProductInOrders
                        .Find((inOrder => inOrder.Product == product));
                    if (productInOrder != null)
                    {
                        if (this.order.Type == OrderType.Incoming)
                        {
                            productCountWithoutThis -= productInOrder.ProductCount;
                        }
                        else
                        {
                            productCountWithoutThis += productInOrder.ProductCount;
                        }
                    }
                }

                if (count > productCountWithoutThis && orderType != OrderType.Incoming)
                {
                    errors.Add(
                        $"Строка {row + 1} количество товара {count} больше остатка товара {productCountWithoutThis}");
                }
                // this.order.ProductInOrders.Add(new ProductInOrder(){ProductCount = count, Product = product, Order = this.order});
            }

            if (errors.Count() > 0)
            {
                MessageBox.Show(String.Join("\n", errors));
                return false;
            }

            return true;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                return;
            }

            if (this.order == null)
            {
                this.order = new Order();
                db.Orders.Add(this.order);
            }

            this.order.Customer = this.comboBox1.SelectedItem as Customer;
            this.order.DateTime = this.dateTimePicker1.Value;
            this.order.Comment = this.TbComment.Text;

            OrderType orderType = (OrderType) Enum.Parse(typeof(OrderType), CbType.SelectedValue.ToString());


            this.order.Type = orderType;
            this.order.ProductInOrders?.Clear();

            this.order.ProductInOrders = new List<ProductInOrder>();

            for (int row = 0; row < this.dataGridView1.RowCount - 1; row++)
            {
                object _count = this.dataGridView1[1, row].Value;
                int count;
                if (_count is int)
                {
                    count = (int) _count;
                }
                else
                {
                    count = int.Parse(_count as string);
                }

                int productId = (int) (this.dataGridView1[0, row] as DataGridViewComboBoxCell).Value;
                Product product = this.db.Products.Find(productId);

                PriceType priceType = (PriceType) Enum.Parse(typeof(PriceType),
                    (this.dataGridView1[2, row] as DataGridViewComboBoxCell).Value.ToString());


                object dicount = this.dataGridView1[3, row].Value;
                Decimal discount = 0;
                if (dicount is decimal)
                {
                    discount = (decimal) dicount;
                }
                else
                {
                    discount = Decimal.Parse(dicount as string);
                }

                this.order.ProductInOrders.Add(new ProductInOrder()
                {
                    ProductCount = count,
                    Product = product,
                    Order = this.order,
                    PriceType = priceType,
                    Discount = discount
                });
            }


            db.SaveChanges();
            this.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var val = this.dataGridView1[0, 0].Value;
            var items = (this.dataGridView1.Columns[0] as DataGridViewComboBoxColumn).Items;
            MessageBox.Show($"col: {e.ColumnIndex}, row: {e.RowIndex}, context {e.Context}");
        }
    }
}