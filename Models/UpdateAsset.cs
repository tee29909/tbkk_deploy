using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class UpdateAsset
    {
        public int UpdateAssetID { get; set; }
        public string AssetName { get; set; }
        public string SerailNumber { get; set; }
        public string MACAddr { get; set; }
        public DateTime InstallDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PONumber { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public virtual Location UpdateAsset_LocationID { get; set; }
        public virtual Company UpdateAsset_CompanyID { get; set; }
        public virtual Department UpdateAsset_SepartmentID { get; set; }
        public virtual Supplier UpdateAsset_SupplierID { get; set; }
        public virtual Employee UpdateAsset_EmployeeID { get; set; }
        public virtual Asset UpdateAsset_AssetID { get; set; }
        public virtual Model UpdateAsset_ModelID { get; set; }
    }
}
