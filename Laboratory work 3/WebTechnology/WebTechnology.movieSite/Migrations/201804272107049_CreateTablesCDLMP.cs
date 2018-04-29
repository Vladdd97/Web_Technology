namespace WebTechnology.movieSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablesCDLMP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Biography = c.String(maxLength: 800),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        LanguageName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        PicturePath = c.String(nullable: false, maxLength: 50),
                        Duration = c.Int(nullable: false),
                        RealeseDate = c.Int(nullable: false),
                        Raiting = c.Int(nullable: false),
                        Free = c.Boolean(nullable: false),
                        Description = c.String(nullable: false, maxLength: 1500),
                        Genre1 = c.String(nullable: false, maxLength: 30),
                        Genre2 = c.String(maxLength: 30),
                        Genre3 = c.String(maxLength: 30),
                        MoviePath = c.String(nullable: false, maxLength: 50),
                        DirectorId = c.Byte(nullable: false),
                        CountryId = c.Byte(nullable: false),
                        LanguageId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Directors", t => t.DirectorId, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.DirectorId)
                .Index(t => t.CountryId)
                .Index(t => t.LanguageId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        PictureName = c.String(nullable: false, maxLength: 30),
                        PicturePath = c.String(nullable: false, maxLength: 70),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Movies", "DirectorId", "dbo.Directors");
            DropForeignKey("dbo.Movies", "CountryId", "dbo.Countries");
            DropIndex("dbo.Movies", new[] { "LanguageId" });
            DropIndex("dbo.Movies", new[] { "CountryId" });
            DropIndex("dbo.Movies", new[] { "DirectorId" });
            DropTable("dbo.Pictures");
            DropTable("dbo.Movies");
            DropTable("dbo.Languages");
            DropTable("dbo.Directors");
            DropTable("dbo.Countries");
        }
    }
}
