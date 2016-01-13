using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return a+b;
        }

        public int Divide(int a, int b)
        {
            //if (b == 0)
            //{
            //    throw new FaultException("Division error: Second operand cannot be zero", new FaultCode("DBZ007"));
            //}

            if (b == 0)
            {
                DivisionDetails details = new DivisionDetails
                {
                    Dividend = a,
                    Divisor = b,
                    Url = "http//www.wiki.com/Division",
                };

                throw new FaultException<DivisionDetails>(details, "Division error: Second operand cannot be zero", new FaultCode("DBZ007"));
            }

            return a / b;
        }
    }
}
