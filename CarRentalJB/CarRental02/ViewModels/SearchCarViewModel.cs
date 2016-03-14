using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;

namespace CarRental02.ViewModels
{
    public class SearchCarViewModel
    {
        public Car CarData { get; set; }
        public virtual CarType CarTypeData { get; set; }
        public virtual Branch BranchData { get; set; }

        public string CarCode
        {
            get
            {
                return CarTypeData.CarCode;
            }
        }

        public double DailyPrice
        {
            get
            {
                return CarTypeData.DailyPrice;
            }
        }

        //public string Branch { get; set; }

        public bool IsAvailable
        {
            get
            {
                return (CarData.CarStatus == CarStatus.Available);
            }
        }
    }
}