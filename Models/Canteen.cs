using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Canteen
    {
        [Key]
        public int CanteenID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Line { get; set; }
        public string Call { get; set; }
        public string Status { get; set; }
    }
}
