using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class DetailOT_Cock
    {
        public int DetailOT_CockID { get; set; }
        public int Hour { get; set; }
        public string Type { get; set; }
        public int CarNumber { get; set; }
        public int Status { get; set; }
        public virtual Employee_Cock EmployeeID { get; set; }
        public virtual Part_Cock PartID { get; set; }
        public virtual CarType_Cock CarType { get; set; }
        public virtual FoodSet_Cock FoodSet { get; set; }
        public virtual OT_Cock OTID { get; set; }
    }
}
