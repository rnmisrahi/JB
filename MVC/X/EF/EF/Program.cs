using EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentDBInitializer initializer = new StudentDBInitializer();
            initializer.InitializeDatabase(new StudentContext());
            //We call SetInitializer to call the Seed, which can add initial data to the DB
            Console.WriteLine("Press Enter");
            Console.ReadLine();

        }
    }
}
