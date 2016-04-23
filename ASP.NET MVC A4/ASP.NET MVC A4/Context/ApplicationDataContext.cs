using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_A4.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ASP.NETMVCA4.Models;

namespace ASP.NET_MVC_A4.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }
        public DbSet<ASP.NETMVCA4.Models.GameConsole> Consoles;
        public DbSet<Game> Games;
        public DbSet<AppUser> AppUsers { get; set; }

        public System.Data.Entity.DbSet<ASP.NETMVCA4.Models.GameConsole> GameConsoles { get; set; }

        public System.Data.Entity.DbSet<ASP.NETMVCA4.Models.Accessory> Accessories { get; set; }
    }
}