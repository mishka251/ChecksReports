using System;
using System.Windows.Forms;

namespace CheckReport
{
    public partial class CustomerDetailForm : Form
    {
        private PostgresDataBaseContext db;
        private Customer customer;
        public CustomerDetailForm(PostgresDataBaseContext db, Customer customer=null)
        {
            this.db = db;
            this.customer = customer;
            InitializeComponent();
            if (customer != null)
            {
                this.TbFirstName.Text = customer.FirstName;
                this.TbLastName.Text = customer.LastName;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.customer == null)
            {
                this.customer = new Customer();
                this.db.Customers.Add(customer);
            }

            this.customer.FirstName = this.TbFirstName.Text;
            this.customer.LastName = this.TbLastName.Text;

            this.db.SaveChanges();
            this.Close();
        }
    }
}