using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_A4.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASP.NET_MVC_A4.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}