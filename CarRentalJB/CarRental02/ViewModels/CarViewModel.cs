using CarRental02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using CarRental02.Controllers;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class CarViewModel
    {
        public Car CarData { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        [Display(Name="Total")]
        [DataType(DataType.Currency)]
        public double Quote
        {
            get
            {
                return Common.Quote(CarData, StartDate, EndDate);
            }
        }

        [Display(Name ="Days Rented")]
        public int DaysRented
        {
            get
            {
                return Common.DaysRented(StartDate, EndDate);
            }
        }
        public SelectList Branches { get; set; }
        public SelectList CarTypes { get; set; }
        public SelectList Reservation { get; set; }

        //private double getQuote()
        //{
        //    double dailyPrice = CarData.CarType.DailyPrice;
        //    if ((StartDate == null) || (EndDate == null))
        //        return 0;//Todo raise an exception and deal with it
        //    DateTime? d1 = StartDate.Value;
        //    DateTime? d2 = EndDate.Value;
        //    TimeSpan ts = EndDate.Value - StartDate.Value;
        //    if (ts.Days <= 0)
        //        return 0;
        //    return ts.Days * dailyPrice;
        //}

    }
}