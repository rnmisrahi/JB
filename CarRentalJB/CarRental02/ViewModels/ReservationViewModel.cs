using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class ReservationViewModel:Car
    {
        public List<Car> CarData { get; set; }
        [NotMapped]
        public virtual List<City> Cities { get; set; }
        public string FilterCarCode { get; set; }
        public string FilterCity { get; set; }
    }
}