using CarRental02.Models;
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

        public static int DaysRented(DateTime? StartDate, DateTime? EndDate)
        {
            if ((StartDate == null) || (EndDate == null))
                return 0;
            if (StartDate > EndDate)
                return 0;
            TimeSpan ts = EndDate.Value - StartDate.Value;
            return ts.Days;
        }

        public static double Quote(Car car, DateTime? StartDate, DateTime? EndDate)
        {
            int days = DaysRented(StartDate, EndDate);
            if (days <= 0)
                return 0;
            return car.CarType.DailyPrice * days;
        }
    }
}