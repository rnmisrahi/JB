﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StockService" in both code and config file together.
    public class StockService : IStockService
    {
        public void DoWork()
        {
        }

        public List<Product> GetAllProducts()
        {
            return Repository.GetAllProducts();
        }
    }
}
