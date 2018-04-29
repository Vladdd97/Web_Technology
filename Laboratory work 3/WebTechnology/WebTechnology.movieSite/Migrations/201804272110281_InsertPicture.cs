namespace WebTechnology.movieSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertPicture : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Pictures (PictureName,PicturePath) VALUES ( 'Wonder','~/Content/images/Wonder.jpg')");

            Sql("INSERT INTO Pictures (PictureName,PicturePath) VALUES ( 'murder on the orient express','~/Content/images/murder on the orient express.jpg')");

            Sql("INSERT INTO Pictures (PictureName,PicturePath) VALUES ( 'it-film','~/Content/images/it-film.jpg')");

        }

        public override void Down()
        {
        }
    }
}
