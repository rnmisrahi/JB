using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf_EI_Polymorphism_Client.PersonReference;

namespace Wcf_EI_Polymorphism_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonReference.PersonServiceClient client = new PersonReference.PersonServiceClient();
            //Console.Write("Enter a Person:");
            //string name = Console.ReadLine();
            //client.AddPerson(name, PersonReference.GlobalPersonType.Person);
            //Console.Write("Enter a Teacher:");
            //name = Console.ReadLine();
            //client.AddPerson(name, PersonReference.GlobalPersonType.Teacher);
            //Console.Write("Enter a Secretary:");
            //name = Console.ReadLine();
            //client.AddPerson(name, PersonReference.GlobalPersonType.Secretary);
            Person[] persons = client.GetAllPersons();
            foreach (Person p in persons)
            {
                //Console.WriteLine("{0} - {1}", p.PersonId, p.PersonName);
                Console.WriteLine(p.ToString());
                //Console.WriteLine(client.Display(p)); //This doesn't work on Teachers or Secretaries
            }
            Console.ReadLine();

            //Let's now use the second service
            StamReference.StamServiceClient stamService = new StamReference.StamServiceClient();
            Console.WriteLine(stamService.GetMessage());
            Console.ReadLine();

        }
    }
}
