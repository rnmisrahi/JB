using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public static class ViewModelfactory
    {
        public static List<string> CreateOperators()
        {
            List<string> o = new List<string>();
            o = OperatorRepository.operators;
            return o;
        }
    }
}