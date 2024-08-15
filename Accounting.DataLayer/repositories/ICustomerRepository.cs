﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<Customers> GetAllCustomers();
        Customers GetCustomerById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
