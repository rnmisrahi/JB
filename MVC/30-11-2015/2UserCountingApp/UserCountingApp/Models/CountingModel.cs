using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserCountingApp.Models
{
    public class CountingModel
    {
        public int ConcurrentUsers { get; set; }
        public int ApplicationSessionUsers { get; set; }
        public int ApplicationAllUsers { get; set; }

        private static CountingModel _instance = null;

        private CountingModel()
        {

        }

        public static CountingModel GetInstance()
        {
            if (_instance == null)
                _instance = new CountingModel();
            return _instance;
        }
    }
}