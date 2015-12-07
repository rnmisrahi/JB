using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public static class OperatorRepository
    {
        public static List<string> operators = new List<string> { "Add", "Subtract", "Mul", "Div" };
    }
}