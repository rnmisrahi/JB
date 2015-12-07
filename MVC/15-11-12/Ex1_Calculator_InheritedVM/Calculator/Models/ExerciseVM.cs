using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class ExerciseVM : Exercise
    {
        public string Operation { get; set; }
        public int? Result { get; set; }
    }
}