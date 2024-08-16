using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities _db = new Accounting_DBEntities();

        ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_db);
                }

                return _customerRepository;
            }
        }

        GenericRepository<AccountingTable> _accountingRepository;

        public GenericRepository<AccountingTable> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepository<AccountingTable>(_db);
                }
                return _accountingRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
