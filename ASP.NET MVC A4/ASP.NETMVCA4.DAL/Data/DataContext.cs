using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NETMVCA4.Models;

namespace ASP.NETMVCA4.DAL.Data
{
    public abstract class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<GameConsole> GameConsoles { get; set; }
    }
    
}