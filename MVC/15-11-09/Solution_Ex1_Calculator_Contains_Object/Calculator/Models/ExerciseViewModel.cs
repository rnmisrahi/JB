using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class ExerciseViewModel
    {
        public Exercise exercise { get; set; }
        public string Operation { get; set; }
        public int? Result { get; set; }

        public ExerciseViewModel()
        {
            exercise = new Exercise();
        }
    }
}