using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewDemo.Models
{
    public class Repository
    {
        private static List<Student> _students = null;
        public static List<Student> AllStudents
        {
            get
            {
                if (_students == null)
                _students =new List<Student>
                {
                    new Student 
                    { 
                        Name="David",
                        Grades=new List<SubjectGrade> 
                        {
                            new SubjectGrade { Subject ="History", Grade=100, },
                            new SubjectGrade { Subject ="Programming", Grade=72, },
                            new SubjectGrade { Subject ="Bible", Grade=100, },

                        },
                    },

                    new Student 
                    { 
                        Name="Shlomo",
                        Grades=new List<SubjectGrade> 
                        {
                            new SubjectGrade { Subject ="History", Grade=94, },
                            new SubjectGrade { Subject ="Programming", Grade=96, },
                            new SubjectGrade { Subject ="Bible", Grade=32, },
                            new SubjectGrade { Subject ="Music", Grade=88, },
                        },
                    },

                };
                return _students;
            }
        }

        public List<Student> GetAll()
        {
            return AllStudents;
        }

    
    }
}