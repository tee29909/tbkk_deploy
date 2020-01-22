using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class KPI
    {
        public int KPIID { get; set; }
        public string KPIDetail { get; set; }
        public int KPISumPoint { get; set; }
        public virtual Employee KPI_EmployeeID { get; set; }
        public virtual GradeHistory KPI_GradeHistoryID { get; set; }
    }
}
