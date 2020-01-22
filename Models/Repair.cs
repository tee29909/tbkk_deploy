using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Repair
    {
        public int RepairID { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public virtual Employee Repair_EmployeeID { get; set; }
        public virtual Report Repair_ReportID { get; set; }
        public virtual Asset Repair_AssetID { get; set; }
    }
}
