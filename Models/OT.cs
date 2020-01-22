using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class OT
    {
        [Key]
        public int OTID { get; set; }

        [Display(Name = "Time Start")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime TimeStart { get; set; }

        [Display(Name = "Time End")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]

        public DateTime TimeEnd { get; set; }


        [Display(Name = "Time End")]
        [DataType(DataType.Date)]
        
        public DateTime date { get; set; }

        [Display(Name = "Day")]
        public string TypeOT { get; set; }
        

        [Display(Name = "Status")]
        public string TypStatus { get; set; }
    }
}
