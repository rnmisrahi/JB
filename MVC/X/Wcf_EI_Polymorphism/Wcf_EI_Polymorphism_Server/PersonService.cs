using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_EI_Polymorphism_Server.Model;

namespace Wcf_EI_Polymorphism_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in both code and config file together.
    public class PersonService : IPersonService
    {
        public int AddPerson(string Name, Global.PersonType pType)
        {
            PersonContext db = new PersonContext();
            Person p;
            switch (pType)
            {
                case Global.PersonType.Teacher:
                    p = new Teacher { PersonName = Name };
                    break;
                case Global.PersonType.Secretary:
                    p = new Secretary { PersonName = Name };
                    break;
                default:
                    p = new Person { PersonName = Name };
                    break;
            }
            db.Persons.Add(p);
            db.SaveChanges();
            return p.PersonId;
        }

        public string Display(Person person)
        {
            Console.WriteLine("Entering Display");
            if (person is Secretary)
            {
                Console.WriteLine("A Secretary");
                return "Secretary: " + person.PersonName;
            }
            if (person is Teacher)
            {
                Console.WriteLine("A Teacher");
                return "Teacher: " + person.PersonName;
            }
            return "This Person is " + person.PersonName;
        }

        public List<Person> GetAllPersons()
        {
            PersonContext db = new PersonContext();
            return db.Persons.ToList();
        }
    }
}
