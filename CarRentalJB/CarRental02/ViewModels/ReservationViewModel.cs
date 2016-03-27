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
        public string Member { get; set; }
        public string CarCode { get; set; }
        public double Quote { get; set; }
        
        public virtual List<City> Cities { get; set; }
        public string FilterCarCode { get; set; }
        public string FilterCity { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> EndDate { get; set; }
    }
}