using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wizard.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext()
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Student> GetAllStudents()
        {
            Student student = new Student { StudentId = "111111111" };
            Students.Add(student);
            return Students;
        }
    }
}