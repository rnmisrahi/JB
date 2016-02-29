using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;
using System.Web.Mvc;

namespace CarRental02.ViewModels
{
    public class CarModelViewModel
    {
        public CarModel CarModelData { get; set; }
        public SelectList Brands { get; set; }
    }
}