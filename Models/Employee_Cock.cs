using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Employee_Cock
    {
        public int Employee_CockID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Company_Cock CompanyID { get; set; }
        public virtual Department_Cock DepartmentName { get; set; }
        public virtual EmployeeType_Cock EmployeeType { get; set; }
        public virtual Position_Cock PositionID { get; set; }
    }
}
