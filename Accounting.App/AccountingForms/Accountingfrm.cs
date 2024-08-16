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

namespace Accounting.App.CustomersForms
{
    public partial class Accountingfrm : Form
    {
        UnitOfWork _db = new UnitOfWork();
        public Accountingfrm()
        {
            InitializeComponent();
        }

        private void Accountingfrm_Load(object sender, EventArgs e)
        {
            Customersdgv.DataSource = _db.CustomerRepository.GetAllCustomers();
        }
    }
}
