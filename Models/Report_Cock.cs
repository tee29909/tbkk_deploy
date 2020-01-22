using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Report_Cock
    {
        public int Report_CockID { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public virtual Employee_Cock EmployeeID { get; set; }
        public virtual Asset_Cock AssetID { get; set; }
    }
}
