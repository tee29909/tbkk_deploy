using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public virtual Employee Report_EmployeeID { get; set; }
        public virtual Asset Report_AssetID { get; set; }
    }
}
