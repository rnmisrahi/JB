using Client.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServiceClient service = new DataServiceClient();
            Person p = service.GetPerson();
            Console.WriteLine(p);

            int a = 5, b = 3;
            service.Swap(ref a, ref b);
            Console.WriteLine("{0} {1}",a,b);

            Person[] members = service.GetAllMembers();
           

            Console.ReadLine();
        }
    }
}

namespace Client.Data
{
    public partial class Person
    {
        public int Amount { get; set; }
        public override string ToString()
        {
            return string.Format("{0} >>>> {1}, {2} {3}", PersonID, PersonName, Amount, myNumber);
        }

    }
}
