using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental02.Models
{
    public class EditCarViewModel
    {
        public Car CarData { get; set; }

        public SelectList Branches { get; set; }
        public SelectList CarTypes { get; set; }
    }
}