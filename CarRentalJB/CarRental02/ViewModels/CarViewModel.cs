using CarRental02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class CarViewModel
    {
        public Car CarData { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Display(Name="Total")]
        public double Quote
        {
            get
            {
                return getQuote();
            }
        }

        public SelectList Branches { get; set; }
        public SelectList CarTypes { get; set; }
        public SelectList Reservation { get; set; }

        private double getQuote()
        {
            double dailyPrice = CarData.CarType.DailyPrice;
            TimeSpan ts = EndDate - StartDate;
            if (ts.Days <= 0)
                return 0;
            return ts.Days * dailyPrice;

        }
    }
}