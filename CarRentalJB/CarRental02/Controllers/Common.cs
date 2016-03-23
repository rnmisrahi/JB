using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental02.Controllers
{
    public static class Common
    {
        public static DateTime Tomorrow()
        {
            DateTime tomorrow = DateTime.Now.AddDays(1);
            if (tomorrow.Hour < 8)
                tomorrow = tomorrow.AddHours(8 - DateTime.Now.Hour).AddMinutes(-DateTime.Now.Minute).AddMinutes(-DateTime.Now.Second);
            return tomorrow;
        }

        public static DateTime DaysAfterToday(int n)
        {
            DateTime dat = Tomorrow().AddDays(n);
            return dat;
        }

        public static DateTime DayAfterTomorrow()
        {
            return DaysAfterToday(1);
        }

    }
}