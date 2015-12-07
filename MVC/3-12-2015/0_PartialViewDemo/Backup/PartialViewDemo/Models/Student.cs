using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewDemo.Models
{
    public class Student
    {
        public string Name { get; set; }
        public List<SubjectGrade> Grades { get; set; }
    }
}