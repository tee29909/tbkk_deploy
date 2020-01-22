using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class AssetJoinNetwork
    {
        public int AssetJoinNetworkID { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public virtual Network AssetJoinNetwork_NetworkID { get; set; }
        public virtual Asset AssetJoinNetwork_AssetID { get; set; }
    }
}
