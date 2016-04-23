using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETMVCA4.Models
{
    public class Game
    {
        public Game()
        { }

        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameStudio { get; set; }
        public string GameDesc { get; set; }
        public decimal GamePrice { get; set; }


    }
}
