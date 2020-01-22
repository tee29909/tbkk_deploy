using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class GradeHistory
    {
        public int GradeHistoryID { get; set; }
        public int GrahAllPoint { get; set; }
        public int GrahBonus { get; set; }
        public int Count { get; set; }
        public int GrahSalaryUp { get; set; }
        public DateTime GrahYear { get; set; }
        public virtual Employee GradeHistory_EmployeeID { get; set; }
    }
}
