﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class Member
    {
        [Required]
        [Key]
        public String SSN { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string HashedPassword { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Member Since")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> FromDate { get; set; }
        public double Discount { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}