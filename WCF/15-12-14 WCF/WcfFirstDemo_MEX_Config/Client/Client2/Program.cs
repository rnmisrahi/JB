﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client2.MyService;

namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            StockServiceClient service = new StockServiceClient();

            Console.WriteLine(service.GetMessage());
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            while (name != "quit")
            {
                try
                {
                    double price = service.GetPrice(name, 0);
                    Console.WriteLine(string.Format("Price: {0}", price));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
            }

        }
    }
}
