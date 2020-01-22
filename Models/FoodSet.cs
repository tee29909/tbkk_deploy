using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class FoodSet
    {
        [Key]
        public int FoodSetID { get; set; }

        public string FoodSetcoManul { get; set; }
        public string NameSet { get; set; }
        [ForeignKey("Canteen")]
        public int Canteen_CanteenID { get; set; }
        public Canteen Canteen { get; set; }
    }
}
