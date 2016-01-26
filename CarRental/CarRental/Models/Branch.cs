using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Display(Name="Name")]
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}