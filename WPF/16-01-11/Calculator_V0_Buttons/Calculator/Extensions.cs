using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Extensions
    {
        public static int? ParseInt(this string intText)
        {
            int value;
            if (int.TryParse(intText, out value))
                return value;
            else
                return null;
        }
    }
}
