using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;

namespace CarRental02.ViewModels
{
    public class BrandViewModel
    {
        public List<CarBrand> Brands { get; set; }
        public CarBrand SelectedBrand { get; set; }
        public string DisplayMode { get; set; }
    }
}