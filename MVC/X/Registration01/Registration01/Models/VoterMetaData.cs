using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration01.Models
{
    [MetadataType(typeof(VoterMetaData))]
    public partial class Voter
    {

    }

    public class VoterMetaData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasCookies { get; set; }
    }
}