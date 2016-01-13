using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF.Model
{
    public class StudentDBInitializer:DropCreateDatabaseIfModelChanges<StudentContext>
    {
        //This 
        //We can Add initial items here... or not.
        //protected override void Seed(Student4Context context)
        //{
        //    base.Seed(context);
        //}
    }
}
