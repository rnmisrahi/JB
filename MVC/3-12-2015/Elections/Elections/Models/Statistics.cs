using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elections.Models
{
    public static class Statistics
    {
        public static List<Candidate> Candidates { get; set; }

        static Statistics()
        {
            Candidates = new List<Candidate>
            {
                new Candidate {Name="Yosi", VoteCount=0},
                new Candidate {Name="Efraim", VoteCount=0},
                new Candidate {Name="Yehoshua", VoteCount=0},
            };
        }
    }
}