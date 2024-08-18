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
using Accounting.Utility.convertors;
using Accounting.Utility;
using Accounting.App.CustomersForms;
using Accounting.ViewModels.Customers;
using System.Data.Entity;
using Accounting.DataLayer;

namespace Accounting.App.Accounting
{
    public partial class AccountingReportsfrm : Form
    {
        public int TypeID;
        UnitOfWork _db = new UnitOfWork();

        public AccountingReportsfrm()
        {
            InitializeComponent();
        }

        void Filter()
        {
            using (UnitOfWork _db = new UnitOfWork())
            {
                Reportdgv.AutoGenerateColumns = false;

                List<AccountingTable> result = new List<AccountingTable>();
                DateTime? startDate;
                DateTime? endDate;

                if ((int)Customercb.SelectedValue != 0)
                {
                    int customerId = int.Parse(Customercb.SelectedValue.ToString());
                    result.AddRange(_db.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == customerId));
                }
                else
                {
                    result.AddRange(_db.AccountingRepository.Get(a => a.TypeID == TypeID));
                }

                if (FromDatemtb.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(FromDatemtb.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.Datetime >= startDate.Value).ToList();
                }
                if (ToDatemtb.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(ToDatemtb.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.Datetime <= endDate.Value).ToList();
                }

                Reportdgv.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = _db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    Reportdgv.Rows.Add(accounting.ID, accounting.CustomerID, customerName, accounting.Amount, accounting.Datetime.ToShamsi(), accounting.Description);
                }
            }
        }

        private void AccountingReportsfrm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork _db = new UnitOfWork())
            {
                List<ListCustomerViewModel> customersList = new List<ListCustomerViewModel>();
                customersList.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "لطفا انتخاب کنید",
                });
                customersList.AddRange(_db.CustomerRepository.GetNameCustomers());
                Customercb.DataSource = customersList;
                Customercb.DisplayMember = "FullName";
                Customercb.ValueMember = "CustomerID";
            }

            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";
                Filter();
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
                Filter();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refreshtsb_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Deletetsb_Click(object sender, EventArgs e)
        {
            if (Reportdgv.CurrentRow != null)
            {
                int accountingid = int.Parse(Reportdgv.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف تراکنش مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _db.AccountingRepository.Delete(accountingid);
                    _db.Save();
                    Filter();
                }
            }
        }

        private void Edittsb_Click(object sender, EventArgs e)
        {
            if (Reportdgv.CurrentRow != null)
            {
                Accountingfrm edit_form = new Accountingfrm();
                edit_form.accountingID = int.Parse(Reportdgv.CurrentRow.Cells[0].Value.ToString());
                if (edit_form.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }

            }
        }

        private void Customercb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
