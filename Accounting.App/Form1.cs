﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.CustomersForms;
using Accounting.App.Accounting;
using Accounting.App.Login;
using Accounting.Utility.convertors;
using Accounting.Business;
using Accounting.ViewModels.Accounting;

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
            this.Hide();
            Loginfrm login_form = new Loginfrm();
            if (login_form.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                Datetssl.Text = DateTime.Now.ToShamsi();
                Timetssl.Text = DateTime.Now.ToString("HH:mm:ss");

                Report();
            }
            else
            {
                Application.Exit();
            }
        }

        void Report()
        {
            ReportAccountingViewModel report = Account.ReportFormMain();
            ReceiveShowlbl.Text = report.Receive.ToString("N0");
            PayShowlbl.Text = report.Pay.ToString("N0");
            RemainShowlbl.Text = report.Remain.ToString("N0");
        }

        private void AddAccountingtsb_Click(object sender, EventArgs e)
        {
            Accountingfrm accounting_form = new Accountingfrm();
            accounting_form.ShowDialog();
            Report();
        }

        private void PayReportstsb_Click(object sender, EventArgs e)
        {
            AccountingReportsfrm reports_form = new AccountingReportsfrm();
            reports_form.TypeID = 2;
            reports_form.ShowDialog();
        }

        private void ReceiveReportstsb_Click(object sender, EventArgs e)
        {
            AccountingReportsfrm reports_form = new AccountingReportsfrm();
            reports_form.TypeID = 1;
            reports_form.ShowDialog();
        }

        private void Datetssl_Click(object sender, EventArgs e)
        {

        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            Timetssl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LoginSettingbtn_Click(object sender, EventArgs e)
        {
            Loginfrm editlogin_form = new Loginfrm();
            editlogin_form.IsEditMode = true;

            if (editlogin_form.ShowDialog() == DialogResult.OK)
            {
                Application.Restart();
            }
        }
    }
}
