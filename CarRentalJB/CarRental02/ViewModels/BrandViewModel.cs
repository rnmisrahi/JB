using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class BrandViewModel
    {
        public List<CarBrand> Brands { get; set; }
        public CarBrand SelectedBrand { get; set; }
        public string DisplayMode { get; set; }
    }
}