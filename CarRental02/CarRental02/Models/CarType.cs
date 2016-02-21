using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public enum Gear
    {
        Automatic, Shift
    }

    public class CarType
    {
        public int CarTypeId { get; set; }
        [Required]
        public int CarModelId { get; set; }

        public double DailyPrice { get; set; }
        public double DailyLatePrice { get; set; }
        public Gear? Gear { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}