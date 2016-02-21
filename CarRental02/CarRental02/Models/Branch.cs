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
        [Display(Name = "Name")]
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}