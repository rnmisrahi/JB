using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdv
{
    class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", First, Second);
        }
    }
}
