using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst02.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public int Votes { get; set; }

        public virtual List<Voter> Voters { get; set; }
    }
}