using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class CarsPart
    {
        public int PartID { get; set; }
        public string namePart { get; set; }
        public IList<DetailOT> DetailOT { get; set; }
        public IList<Cars> ListCars { get; set; }
    }
}
