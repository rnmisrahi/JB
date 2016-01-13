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
            ServiceHost host = new ServiceHost(typeof(InventoryService));
            host.Open();
            Console.WriteLine("Listening......");
            Console.ReadLine();
        }
    }
}
