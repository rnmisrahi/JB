using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class Employee : Member
    {
        public string Shift { get; set; }
        public double Salary { get; set; }
    }
}