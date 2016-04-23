﻿using ASP.NETMVCA4.Contracts.Data;
using ASP.NETMVCA4.Contracts.Repositories;
using ASP.NETMVCA4.DAL.Repositories;
using ASP.NETMVCA4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETMVCA4.Contracts.Repositories
{
    
        class ConsoleRepository : RepositoryBase<ASP.NETMVCA4.Models.GameConsole>
        {
            public ConsoleRepository(DataContext context)
                : base(context)
            {
                if (context == null)
                    throw new ArgumentNullException();//checks to see if null
            }

        }
    
}