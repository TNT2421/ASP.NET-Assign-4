using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP.NETMVCA4.Contracts.Repositories;
using ASP.NETMVCA4.Models;
using ASP.NETMVCA4.Contracts.Data;

namespace ASP.NETMVCA4.DAL.Repositories
{
    public class AccessoryRepository : RepositoryBase<Accessory>
    {
        public AccessoryRepository(DataContext context)
                : base(context)
            {
                if (context == null)
                    throw new ArgumentNullException();//checks to see if null
            }
    }
}
