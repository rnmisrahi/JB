using CarRental02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class CarTypeViewModel
    {
        public CarType CarTypeData { get; set; }
        public SelectList CarModels { get; set; }
        public Car CarEdited { get; set; }//When adding a CarType while editing or adding a Car
    }
}