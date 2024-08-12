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
    }
}
