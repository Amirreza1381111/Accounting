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
using System.IO;

namespace Accounting.App.CustomersForms
{
    public partial class AddOrEditCustomerfrm : Form
    {
        UnitOfWork db = new UnitOfWork();

        public int customerid = 0;

        public AddOrEditCustomerfrm()
        {
            InitializeComponent();
        }

        private void FullNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(PcCustomerpb.ImageLocation);
                string path = Application.StartupPath + "/Images/";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                PcCustomerpb.Image.Save(path + ImageName);

                Customers customer = new Customers
                {
                    FullName = FullNametxb.Text,
                    Mobile = Mobiletxb.Text,
                    Email = Emailtxb.Text,
                    Address = Addresstxb.Text,
                    CustomerImage = ImageName,
                };

                if (customerid == 0)
                {
                    db.CustomerRepository.InsertCustomer(customer);
                }
                else
                {
                    customer.CustomerID = customerid;
                    db.CustomerRepository.UpdateCustomer(customer);
                }
                db.Save();

                DialogResult = DialogResult.OK;
            }
        }

        private void SelectPicturebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PcCustomerpb.ImageLocation = openFile.FileName;
            }
        }

        private void AddOrEditCustomerfrm_Load(object sender, EventArgs e)
        {
            if (customerid != 0)
            {
                this.Text = "ویرایش شخص";
                this.Savebtn.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(customerid);
                this.FullNametxb.Text = customer.FullName;
                this.Mobiletxb.Text = customer.Mobile;
                this.Emailtxb.Text = customer.Email;
                this.Addresstxb.Text = customer.Address;
                PcCustomerpb.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }
    }
}
