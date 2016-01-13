using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_EI_Polymorphism_Server.Model
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Teacher> Techers { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
    }
}
