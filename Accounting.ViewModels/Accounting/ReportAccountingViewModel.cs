using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModels.Accounting
{
    public class ReportAccountingViewModel
    {
        public float Receive { get; set; }

        public float Pay { get; set; }

        public float Remain { get; set; }
    }
}