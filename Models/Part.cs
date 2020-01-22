using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Part
    {
        [Key]
        public int PartID { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
    }
}
