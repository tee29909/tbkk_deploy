using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Depasments
    {
        public int DepasmentsID { get; set; }
        public string DepasmentsName { get; set; }
        public int DepasmentsCount { get; set; }
        public int CarCount { get; set; }
        public int FoodCount { get; set; }


        public IList<Parts> ListParts { get; set; }
        public IList<Foods> ListFoods { get; set; }
    }
}
