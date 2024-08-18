using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.convertors
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime Datetime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(Datetime) + "/" + pc.GetMonth(Datetime).ToString("00") + "/" + pc.GetDayOfMonth(Datetime).ToString("00");
        }

        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
