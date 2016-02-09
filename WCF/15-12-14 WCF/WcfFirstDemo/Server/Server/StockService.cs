using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class StockService : IStockService
    {
        public double GetPrice(string productName, int prefix)
        {
            switch (productName)
            {
                case "bag":
                    return 50 * prefix;
                case "chair":
                    return 120;
                default:
                    return 99.99;
            }
        }

        public string GetMessage()
        {
            return "Hello client";
        }

        public string GetMessage(int x)
        {
            return "Hello client";
        }
    }
}
