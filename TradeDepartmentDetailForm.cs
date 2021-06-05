using System;
using System.Windows.Forms;

namespace CheckReport
{
    public partial class TradeDepartmentDetailForm : Form
    {
        private PostgresDataBaseContext db;
        private TradeDepartment department = null;
        public TradeDepartmentDetailForm(PostgresDataBaseContext db, TradeDepartment department=null)
        {
            InitializeComponent();
            this.db = db;
            this.department = department;
            if (department != null)
            {
                this.TbName.Text = this.department.Name;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.department == null)
            {
                this.department = new TradeDepartment();
                db.TradeDepartments.Add(this.department);
            }

            this.department.Name = this.TbName.Text;

            db.SaveChanges();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}