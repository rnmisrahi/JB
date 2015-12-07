using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class ExerciseVM
    {
        public Exercise Exercise { get; set; }
        public string Operation { get; set; }
        public int? Result { get; set; }
        public int MyProperty { get; set; }

        public ExerciseVM()
        {
            Exercise = new Exercise();
        }
    }
}