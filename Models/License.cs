using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class License
    {
        public int LicenseID { get; set; }
        public string LicenseName { get; set; }
        public string SoftewareName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public string Attachfiles { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public virtual Model License_ModelID { get; set; }
        public virtual Supplier License_SupplierID { get; set; }
        public virtual Department License_DepartmentID { get; set; }
        public virtual Company License_CompanyID { get; set; }
    }
}
