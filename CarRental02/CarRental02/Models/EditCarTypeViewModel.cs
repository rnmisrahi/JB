using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental02.Models
{
    public class EditCarTypeViewModel
    {
        public CarType CarTypeData { get; set; }
        public SelectList CarModels { get; set; }
        public Car CarEdited { get; set; }//When adding a CarType while editing or adding a Car
    }
}