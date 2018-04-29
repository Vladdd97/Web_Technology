namespace WebTechnology.movieSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertLanguage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Languages (LanguageName) VALUES ( 'English')");

            Sql("INSERT INTO Languages (LanguageName) VALUES ( 'Spanish')");

            Sql("INSERT INTO Languages (LanguageName) VALUES ( 'Chinese')");
        }
        
        public override void Down()
        {
        }
    }
}
