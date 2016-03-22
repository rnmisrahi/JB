using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public int CityId { get; set; }
        [Display(Name = "Branch")]
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        [Display(Name = "City-Branch")]
        public string Description
        {
            get
            {
                using (var db = new ApplicationDbContext())
                {
                    var city = db.Cities.Find(CityId);
                    return String.Format("{0} - {1}", city.CityName, BranchName);
                }
            }
        }

        public virtual City City { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}