using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class MemberViewModel
    {
        public Member MemberData { get; set; }
        private string mCityName;
        public string CityName
        {
            get
            {
                if (MemberData.CityId == 1)
                    return "Unknown";
                return mCityName;
            }
            set
            {
                mCityName = value;
            }
        }
    }
}