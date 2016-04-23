using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETMVCA4.Models
{
    public class Accessory
    {
        public int AccessoryId { get; set; }
        public string AccessoryName { get; set; }
        public string AccessoryDesc { get; set; }
        public decimal AccessoryPrice { get; set; }
    }
}
