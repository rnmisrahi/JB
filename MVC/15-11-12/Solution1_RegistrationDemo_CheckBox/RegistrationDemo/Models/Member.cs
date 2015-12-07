﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seniority { get; set; }
        public bool IsProgrammer { get; set; }
        public string action { get; set; } //Update or Edit
    }
}