using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<Customers> GetAllCustomers();
        List<ListCustomerViewModel> GetNameCustomers(string filter = "");
        Customers GetCustomerById(int customerId);
        string GetCustomerNameById(int customerId);
        int GetCustomerIDByName(string name);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
