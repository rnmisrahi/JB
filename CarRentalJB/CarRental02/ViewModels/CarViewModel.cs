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
    public class CarViewModel
    {
        public Car CarData { get; set; }

        public SelectList Branches { get; set; }
        public SelectList CarTypes { get; set; }
        public SelectList Reservation { get; set; }
    }
}