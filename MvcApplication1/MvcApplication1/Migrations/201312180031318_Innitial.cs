namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Innitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        SenderID = c.Long(nullable: false),
                        FilePath = c.String(maxLength: 60),
                        Length = c.Double(nullable: false),
                        Public = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Person", t => t.SenderID, cascadeDelete: true)
                .Index(t => t.SenderID);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Message", "SenderID", "dbo.Person");
            DropIndex("dbo.Message", new[] { "SenderID" });
            DropTable("dbo.Person");
            DropTable("dbo.Message");
        }
    }
}
