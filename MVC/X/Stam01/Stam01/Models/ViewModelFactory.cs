using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stam01.Models
{
    public static class ViewModelFactory
    {
        public static List<Candidate> CreateCandidates()
        {
            List<Candidate> cs = new List<Candidate>();
            foreach (Candidate c in Repository.Candidates)
            {
                cs.Add(c);
            }
            return cs;
        }
    }
}