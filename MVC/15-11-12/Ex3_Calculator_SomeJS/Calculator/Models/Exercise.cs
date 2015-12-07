using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{

    //enum Operators
    //{
    //    Add, Subtract, Mul, Div,
    //}

    public class Exercise
    {
        public int First { get; set; }
        public int Second { get; set; }
        public string Operation { get; set; }
        public int? Result { get; set; }
    }
}