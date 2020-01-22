using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Competency
    {
        public int CompetencyID { get; set; }
        public string CompDetaill { get; set; }
        public int CompSumPoint { get; set; }
        public DateTime Date { get; set; }
        public virtual Employee Competency_EmployeeID { get; set; }
        public virtual GradeHistory Competency_GradeHistoryID { get; set; }

    }
}
