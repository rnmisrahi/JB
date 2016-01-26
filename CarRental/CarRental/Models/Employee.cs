using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Employee:Member
    {
        public string Shift { get; set; }
        public double Salary { get; set; }
    }
}