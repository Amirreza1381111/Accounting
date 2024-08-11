using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();

            Customers AddCustomer = new Customers()
            {
                FullName = "Reza Mirahmadi",
                Mobile = "09104135687",
                CustomerImage = "NoPhoto",
            };

            //customer.DeleteCustomer(3);
            //customer.DeleteCustomer(4);

            //customer.Save();

            var customers = db.CustomerRepository.GetAllCustomers();
        }
    }
}
