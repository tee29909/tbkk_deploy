using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class UpdateLicense
    {
        public int UpdateLicenseID { get; set; }
        public DateTime Date { get; set; }
        public string LicenseName { get; set; }
        public string SoftwareName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public string Attachfiles { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public virtual Model UpdateLicense_ModelID { get; set; }
        public virtual Supplier UpdateLicense_SupplierID { get; set; }
        public virtual Department UpdateLicense_DepartmentID { get; set; }
        public virtual Company UpdateLicense_CompanyID { get; set; }
        public virtual License UpdateLicense_LicenseID { get; set; }
    }
}
