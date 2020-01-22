using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Relationship
    {
        public int RelationshipID { get; set; }
        public virtual Asset Relationship_AssetIDmom { get; set; }
        public virtual Asset Relationship_AssetIDson { get; set; }
        public string Status { get; set; }
    }
}
