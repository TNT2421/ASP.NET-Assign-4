using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_A4.Models
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

    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
    
}