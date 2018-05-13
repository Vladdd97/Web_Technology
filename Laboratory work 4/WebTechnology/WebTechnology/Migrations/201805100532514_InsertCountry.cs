namespace WebTechnology.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCountry : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'USA')");

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'China')");

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'UK')");

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'France')");

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'Australia')");

            Sql("INSERT INTO Countries (CountryName) VALUES ( 'Spain')");


        }

        public override void Down()
        {
        }
    }
}
