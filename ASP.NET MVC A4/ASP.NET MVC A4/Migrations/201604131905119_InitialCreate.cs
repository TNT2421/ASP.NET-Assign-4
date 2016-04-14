namespace ASP.NET_MVC_A4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Game_Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        GameStudio = c.String(),
                        ERSB = c.String(),
                    })
                .PrimaryKey(t => t.Game_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
