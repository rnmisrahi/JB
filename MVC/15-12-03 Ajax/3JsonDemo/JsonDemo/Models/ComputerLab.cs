using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonDemo.Models
{
    public static class ComputerLab
    {
        public static Computer[] Computers { get; set; }

        static ComputerLab()
        {
            Computers = new Computer[]
            {
                new Computer {  Company="aaa", CPU="Pentium7", Memory=2000, 
                    Drives= new DiskDrive [] 
                    { 
                        new DiskDrive { Capacity=1000, Speed=771, },
                        new DiskDrive { Capacity=2000, Speed =778, },
                    }
                },
                new Computer {  Company="bbb", CPU="X6", Memory=5999, 
                    Drives= new DiskDrive [] 
                    { 
                        new DiskDrive { Capacity=16000, Speed=2001, },
                        new DiskDrive { Capacity=9000, Speed =2009, },
                    }
                }
            };
        }
    }
}