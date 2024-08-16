using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            Customersfrm customer_form = new Customersfrm();
            customer_form.ShowDialog();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {

        }

        private void AddAccountingtsb_Click(object sender, EventArgs e)
        {
            Accou accounting_form = new Accountingfrm();
        }
    }
}
