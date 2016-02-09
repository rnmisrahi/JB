using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Calculator;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient calculator = new CalculatorServiceClient();
            int result = calculator.Add(5, 7);

            Console.WriteLine(result);
            Console.WriteLine("\n\nDone");
            Console.ReadLine();

        }
    }
}
