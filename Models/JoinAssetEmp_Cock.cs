using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class JoinAssetEmp_Cock
    {
        public int JoinAssetEmp_CockID { get; set; }
        public string Note { get; set; }
        public string Strint { get; set; }
        public virtual Employee_Cock EmployeeID { get; set; }
        public virtual Asset_Cock AssetName { get; set; }
    }
}
