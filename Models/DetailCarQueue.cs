using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class DetailCarQueue
    {
        [Key]
        public int DetailCarQueueID { get; set; }

        [ForeignKey("Employee")]
        public int DetailCarQueue_EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("CarQueue")]
        public int DetailCarQueue_CarQueueID { get; set; }
        public CarQueue CarQueue { get; set; }

    }
}
