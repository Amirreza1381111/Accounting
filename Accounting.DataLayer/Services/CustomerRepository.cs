using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.repositories;
using System.Data.Entity;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities _db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            this._db = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return _db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                _db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                _db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                _db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = _db.Customers.Find(customerId);

                _db.Customers.Remove(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
