using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class CarType
    {
        [Key]
        public int CarTypeID { get; set; }

        public string NameCar { get; set; }

        public int Seat { get; set; }
        [ForeignKey("CompanyCar")]
        public int CompanyCarID { get; set; }
        public CompanyCar CompanyCar { get; set; }

    }
}
