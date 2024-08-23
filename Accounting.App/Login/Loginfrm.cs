using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Context;


namespace Accounting.App.Login
{
    public partial class Loginfrm : Form
    {
        public bool IsEditMode = false;

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                this.Text = "تنضیمات ورود";
                this.Logbtn.Text = "ذخیره تغییرات";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    Usernametxb.Text = login.UserName.ToString();
                    Passwordtxb.Text = login.Password.ToString();
                }
            }
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (IsEditMode)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = Usernametxb.Text;
                        login.Password = Passwordtxb.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        if (RtlMessageBox.Show("تغییرات با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {   
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == Usernametxb.Text && l.Password == Passwordtxb.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("نام کاربری یا رمز عبور اشتباه است.", "خطا", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
