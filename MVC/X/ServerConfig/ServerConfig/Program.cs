﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(StockService));
            host.Open();
            Console.WriteLine("Listening...");
            Console.ReadLine();
        }
    }
}
