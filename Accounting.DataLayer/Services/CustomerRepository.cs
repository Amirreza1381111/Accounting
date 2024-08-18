using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.repositories;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

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
                var local = _db.Set<Customers>()
                         .Local
                         .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
                if (local != null)
                {
                    _db.Entry(local).State = EntityState.Detached;
                }
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

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return _db.Customers.Where(c => c.FullName.Contains(parameter) || c.Mobile.Contains(parameter) || c.Email.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return _db.Customers.Select(c => new ListCustomerViewModel {CustomerID=c.CustomerID, FullName=c.FullName }).ToList();
            }
            return _db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel { CustomerID = c.CustomerID, FullName = c.FullName }).ToList();
        }

        public int GetCustomerIDByName(string name)
        {
            return _db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return _db.Customers.First(c => c.CustomerID == customerId).FullName;
        }
    }
}
