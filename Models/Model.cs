using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public virtual Brand Model_BrandID { get; set; }
        public virtual Category Model_CategoryID { get; set; }
    }
}
