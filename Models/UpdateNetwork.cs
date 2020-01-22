using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk.Models
{
    public class UpdateNetwork
    {
        public int UpdateNetworkID { get; set; }
        public DateTime Date { get; set; }
        public string IpAddr { get; set; }
        public string Note { get; set; }
        public string Password { get; set; }
        public virtual Employee UpdateNetwork_EmployeeID { get; set; }
        public virtual Network UpdateNetwork_NetworkID { get; set; }

    }
}
