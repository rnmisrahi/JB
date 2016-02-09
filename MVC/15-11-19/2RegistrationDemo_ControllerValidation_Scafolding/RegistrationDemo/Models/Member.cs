using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class Member
    {
        [Required]
        [Range(1, 9999)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Seniority { get; set; }
        public bool IsProgrammer { get; set; }
        public int CityId { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAcceptConditions { get; set; }
    }
}