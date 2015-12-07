using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst02.Models
{
    public class Voter
    {
        public int VoterId { get; set; }
        public string Name { get; set; }
        public bool AlreadyVoted { get; set; }
        public int CandidateId { get; set; }

        virtual public Candidate Candidate { get; set; }
    }
}