using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Wizard.Models
{
    public class StudentDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {

        protected override void Seed(StudentContext context)
        {
            base.Seed(context);
            context.Students.Add(
                new Student
                {
                    StudentId = "123456789",
                    StudentName = "Ruben",
                    LikesGirls = true,
                    Course = "Pick a Course",
                    Hebrew = true,
                    Comments = "None"
                }
            );
            context.SaveChanges();
        }
    }
}