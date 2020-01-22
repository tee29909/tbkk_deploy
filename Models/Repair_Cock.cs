using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Repair_Cock
    {
        public int Repair_CockID { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public virtual Employee_Cock EmployeeID { get; set; }
        public virtual Report_Cock ReportID { get; set; }
        public virtual Asset_Cock AssetID { get; set; }

    }

}
