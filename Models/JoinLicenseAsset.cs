using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class JoinLicenseAsset
    {
        public int JoinLicenseAssetID { get; set; }
        public string Status { get; set; }
        public virtual License JoinLicenseAsset_License { get; set; }
        public virtual Asset JoinLicenseAsset_AssetID { get; set; }
    }
}
