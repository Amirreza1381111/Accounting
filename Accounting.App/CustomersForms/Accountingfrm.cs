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
using Accounting.DataLayer;
using ValidationComponents;

namespace Accounting.App.CustomersForms
{
    public partial class Accountingfrm : Form
    {
        public int accountingID = 0;

        UnitOfWork _db = new UnitOfWork();
        public Accountingfrm()
        {
            InitializeComponent();
        }

        private void Accountingfrm_Load(object sender, EventArgs e)
        {
            Customersdgv.AutoGenerateColumns = false;
            Customersdgv.DataSource = _db.CustomerRepository.GetAllCustomers();
            if (accountingID != 0)
            {
                this.Text = "ویرایش تراکنش";
                this.Savebtn.Text = "ویرایش";
                var accounting = _db.AccountingRepository.GetById(accountingID);
                var customerName = _db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                Receiveradio.Checked = (accounting.TypeID == 1) ? true : false;
                Payradio.Checked = !Receiveradio.Checked;
                CustomerFullNametxb.Text = customerName;
                Amountnud.Value = int.Parse(accounting.Amount.ToString());
                Descriptiontxb.Text = accounting.Description;
            }
        }

        private void SearchCustomertxb_TextChanged(object sender, EventArgs e)
        {
            Customersdgv.DataSource = _db.CustomerRepository.GetCustomersByFilter(SearchCustomertxb.Text);
        }

        private void Customersdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerFullNametxb.Text = Customersdgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (Receiveradio.Checked || Payradio.Checked)
                {
                    AccountingTable accounting = new AccountingTable
                    {
                        CustomerID = _db.CustomerRepository.GetCustomerIDByName(CustomerFullNametxb.Text),
                        TypeID = (Receiveradio.Checked) ? 1 : 2,
                        Amount = int.Parse(Amountnud.Value.ToString()),
                        Description = Descriptiontxb.Text,
                        Datetime = DateTime.Now,
                    };

                    if (accountingID == 0)
                    {
                        _db.AccountingRepository.Insert(accounting);
                        _db.Save();
                        RtlMessageBox.Show("تراکنش شما با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            accounting.ID = accountingID;
                            db.AccountingRepository.Update(accounting);
                            db.Save();
                        }
                        RtlMessageBox.Show("تراکنش شما با موفقیت بروزرسانی شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را مشخص کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Amountnud_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
