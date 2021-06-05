using System;
using System.ComponentModel;
using System.Linq;
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

            BindingList<TradeDepartment>
                objects = new BindingList<TradeDepartment>(this.db.TradeDepartments.ToList());
            
            CbTradeDepartment.ValueMember = null;
            CbTradeDepartment.DisplayMember = "Name";
            CbTradeDepartment.DataSource = objects;
            
            if (customer != null)
            {
                this.TbShortName.Text = customer.ShortName;
                this.TbFullName.Text = customer.FullName;
                this.TbOKPO.Text = customer.OKPO;
                this.TbINN.Text = customer.INN;
                this.TbKPP.Text = customer.KPP;
                this.TbAdress.Text = customer.Address;
                this.TbPhoneNumber.Text = customer.PhoneNumber;
                this.TbStatus.Text = customer.Status;
                this.CbTradeDepartment.SelectedItem = customer.Department;
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

            this.customer.ShortName = this.TbShortName.Text;
            this.customer.FullName = this.TbFullName.Text;
            this.customer.INN = this.TbINN.Text;
            this.customer.KPP = this.TbKPP.Text;
            this.customer.OKPO = this.TbOKPO.Text;
            this.customer.Address = this.TbAdress.Text;
            this.customer.Status = this.TbStatus.Text;
            this.customer.PhoneNumber = this.TbPhoneNumber.Text;
            this.customer.Department = (TradeDepartment)this.CbTradeDepartment.SelectedItem;
            
            
            this.db.SaveChanges();
            this.Close();
        }
    }
}