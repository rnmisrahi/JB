using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wizard
{
    public class Data
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public bool LikesGirls { get; set; }
        public string Course { get; set; }
        public bool Hebrew { get; set; }
        public string Comments { get; set; }

        public List<Data> Select { get; set; }
    }
}