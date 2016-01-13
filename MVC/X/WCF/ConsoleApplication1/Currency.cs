using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Currency:ICurrency
    {
        [OperationContract]
        public double GetValue(string name)
        {
            switch (name)
            {
                case "dollar":
                        return 3.86;
                case "peso":
                    return 40;
                default: return 99.99;
            }
        }
    }
}
