using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.App.CustomersForms;

namespace Accounting.App
{
    public partial class Customersfrm : Form
    {
        public void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Customersdgv.DataSource = db.CustomerRepository.GetAllCustomers().ToList();
            }
        }

        public Customersfrm()
        {
            InitializeComponent();
        }

        private void Customersfrm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void SearchCustomertstb_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Customersdgv.DataSource = db.CustomerRepository.GetCustomersByFilter(SearchCustomertstb.Text).ToList();
            }
        }

        private void SearchCustomertstb_Click(object sender, EventArgs e)
        {

        }

        private void RefrshCustomerstsb_Click(object sender, EventArgs e)
        {
            SearchCustomertstb.Text = "";
            BindGrid();
        }

        private void AddCustomertsb_Click(object sender, EventArgs e)
        {
            AddOrEditCustomerfrm addfrm = new AddOrEditCustomerfrm();
            if (addfrm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void DeleteCustomertsb_Click(object sender, EventArgs e)
        {
            if (Customersdgv.CurrentRow != null)
            {
                string fullname = Customersdgv.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {fullname} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int customerid = int.Parse(Customersdgv.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerid);
                        db.Save();
                    }
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را برای حذف انتخاب کنید!");
            }
        }

        private void EditCustomertsb_Click(object sender, EventArgs e)
        {
            AddOrEditCustomerfrm editfrm = new AddOrEditCustomerfrm();
            if (Customersdgv.CurrentRow != null)
            {
                int customerid = int.Parse(Customersdgv.CurrentRow.Cells[0].Value.ToString());
                editfrm.customerid = customerid;
                editfrm.ShowDialog();
            }
        }
    }
}
