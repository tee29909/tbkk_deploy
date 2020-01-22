using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Asset_Cock
    {
        public int Asset_CockID { get; set; }
        public string AssetName { get; set; }
        public string SerailNumber { get; set; }
        public DateTime InstallDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }
        public string Status { get; set; }
        public virtual Department_Cock DepartmentID { get; set; }
        public virtual Company_Cock CompanyID { get; set; }
        public virtual Supplier_Cock SupplierID { get; set; }
        public virtual Employee_Cock EmployeeID { get; set; }
    }
}
