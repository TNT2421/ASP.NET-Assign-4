using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETMVCA4.Models
{
    public class Console
    {
        public int ProductID { get; set; }
        [MaxLength(255)]
        public string Brand { get; set; }
        public string ProductLine { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
    }
}
