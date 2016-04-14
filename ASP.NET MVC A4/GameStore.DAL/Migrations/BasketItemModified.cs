using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class BasketItemModified : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BasketItems", "BasketItems");
        }

        public override void Down()
        {
            AddColumn("dbo.BasketItems", "BasketItems", c => c.Int(nullable: false));
        }
    }
}
