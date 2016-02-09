using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.Calculator;

namespace Client
{
    class Program
    {
        static CalculatorServiceClient calculator;

        static void Main(string[] args)
        {
            calculator = new CalculatorServiceClient();
            int result = calculator.Add(5, 7);
            Console.WriteLine(result);

            Divide(36, 4);
            Divide(18, 0);
            Divide(42, 7);

            Console.WriteLine("\n\nDone");
            Console.ReadLine();

        }

        private static void Divide(int v1, int v2)
        {
            try
            {
                //// Alt 1
                // CalculatorServiceClient calculator = new CalculatorServiceClient();
                Console.WriteLine(calculator.Divide(v1, v2));
            }

            catch (FaultException<DivisionDetails> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Details: {0}/{1}, Url: {2}", ex.Detail.Dividend, ex.Detail.Divisor, ex.Detail.Url);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("^^^^^\n\n");
            }
        }

        //// Alt 2:
        //// HandleError method
    }
}
