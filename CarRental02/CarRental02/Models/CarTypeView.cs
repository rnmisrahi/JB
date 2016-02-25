using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models
{
    [ComplexType]
    public class CarTypeView
    {
        private CarType carType;
        public CarTypeView()
        {
            carType = new CarType();
        }
        public string CarTypeData { get
            {
            };
        [Display(Name = "Car Code")]
        public string CarCode { get; set; }

    }
}