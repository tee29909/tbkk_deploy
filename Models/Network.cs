using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class Network
    {
        public int NetworkID { get; set; }
        public string NetworkName { get; set; }
        public string IpAddr { get; set; }
        public string Note { get; set; }
        public string Password { get; set; }
    }
}
