using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo.Models
{
    public static class PersonListModel
    {
        private static List<Person> _members;
        public static List<Person> Members
        {
            get
            {
                if (_members == null)
                {
                    _members = new List<Person> 
                    {
                        new Person{ ID=111, Name="Shimon", Degree=6, Amount=4000, LikeBananas=true, },
                        new Person{ ID=222, Name="Tikva", Degree=2, Amount=16000, LikeBananas=false, },
                        new Person{ ID=333, Name="Sam", Degree=1, Amount=1000, LikeBananas=false, },
                    };
                }
                return _members;
            }
        }
    }
}