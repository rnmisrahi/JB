using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental02.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class ReservationViewModel:Car
    {
        public List<Car> CarData { get; set; }
        [MaxLength(1)]
        public string CarCode { get; set; }
        public double Quote { get; set; }
        [NotMapped]
        public virtual List<City> Cities { get; set; }
        public string FilterCarCode { get; set; }
        public string FilterCity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}