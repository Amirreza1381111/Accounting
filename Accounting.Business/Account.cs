using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Accounting;
using Accounting.DataLayer.Context;

namespace Accounting.Business
{
    public class Account
    {
        public static ReportAccountingViewModel ReportFormMain()
        {
            ReportAccountingViewModel rp = new ReportAccountingViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var receive = db.AccountingRepository.Get(a => a.TypeID == 1 && a.Datetime >= startDate && a.Datetime <= endDate).Select(a=> a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeID == 2 && a.Datetime >= startDate && a.Datetime <= endDate).Select(a => a.Amount).ToList();

                rp.Receive = (float) receive.Sum();
                rp.Pay = (float) pay.Sum();
                rp.Remain = (float) (receive.Sum() - pay.Sum());
            }

            return rp;

        }
    }
}
