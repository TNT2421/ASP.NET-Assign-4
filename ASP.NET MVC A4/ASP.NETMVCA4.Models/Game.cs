using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETMVCA4.Models
{
    public class Game
    {
        [Key]
        public int Game_Id { get; set; }
        public string GameName { get; set; }
        public string GameStudio { get; set; }

        public string ERSB { get; set; }

        public string desc { get; set; }

        public decimal price { get; set; }
    }
}
