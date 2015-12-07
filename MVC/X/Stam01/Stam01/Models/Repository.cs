using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stam01.Models
{
    public static class Repository
    {
        public static List<Candidate> Candidates = new List<Candidate>{
            new Candidate{Name="John", votes=0},
            new Candidate{Name="Steve", votes = 0},
            new Candidate{Name="Mike", votes = 0}
        };

    }
}