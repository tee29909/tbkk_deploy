using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class JoinAssetEmp
    {
        public int JoinAssetEmpID { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public virtual Employee JoinAssetEmp_EmployeeID { get; set; }
        public virtual Asset JoinAssetEmp_AssetID { get; set; }
    }
}
