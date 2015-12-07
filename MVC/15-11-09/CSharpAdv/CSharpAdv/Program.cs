using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            // DynamicDemo();

            // VarDemo();

            int? x = 7;

            x = 19;
            // if (x==null)

            int y = 9;

            x = y;
            y = (int)x;

            Console.WriteLine("\nDone");
            Console.ReadLine();
        }

        private static void VarDemo()
        {
            var x = 17;
            var y = "xyz";
            var z = 56.12;
            var f = new Pair();

            var a = new { Numerator = 3, Denominator = 7 };



            // x = "xyz";
        }

        private static void DynamicDemo()
        {
            object x = 5;
            x = "Hamesh";
            Console.WriteLine(x);

            dynamic p = new Pair { First = 1, Second = 5, };
            Console.WriteLine(p);

            Console.WriteLine(p.First);
            Console.WriteLine(p.Third);
        }

        private static dynamic f(dynamic x)
        {
            return null;
        }
    }
}
