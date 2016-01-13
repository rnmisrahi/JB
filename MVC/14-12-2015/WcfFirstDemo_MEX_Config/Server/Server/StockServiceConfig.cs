using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StockServiceConfig" in both code and config file together.
    public class StockServiceConfig : IStockServiceConfig
    {
        public void DoWork()
        {
        }
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
