using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonDemo.Models
{
    public class Computer
    {
        public string CPU { get; set; }
        public string Company { get; set; }
        public int Memory { get; set; }
        public DiskDrive[] Drives { get; set; }
    }
}