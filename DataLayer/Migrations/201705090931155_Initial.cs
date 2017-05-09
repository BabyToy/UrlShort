namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.shorturls",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    urllong = c.String(nullable: false, maxLength: 1000),
                    DateAdded = c.DateTime(nullable: false),
                    Segment = c.String(nullable: false, maxLength: 30),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.stats",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    ip = c.String(nullable: false, maxLength: 50),
                    referrer = c.String(maxLength: 500),
                    ShortUrl_Id = c.Int(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.shorturls", t => t.ShortUrl_Id)
                .Index(t => t.ShortUrl_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.stats", "ShortUrl_Id", "dbo.shorturls");
            DropIndex("dbo.stats", new[] { "ShortUrl_Id" });
            DropTable("dbo.stats");
            DropTable("dbo.shorturls");
        }
    }
}
