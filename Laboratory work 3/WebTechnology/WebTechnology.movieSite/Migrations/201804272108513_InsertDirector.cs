namespace WebTechnology.movieSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDirector : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Brad'," +
                "'Peyton'," +
                "'Brad Peyton (born May 27, 1978) is a Canadian film director, writer, and producer. He is best known for directing the 2015 disaster film, San Andreas.' )");

            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Ryan'," +
                "'Coogler'," +
                "'Ryan Kyle Coogler (born May 23, 1986)[1] is an American film director, producer, and screenwriter. His first feature film, Fruitvale Station (2013), won the top audience and grand jury awards in the U.S. dramatic competition at the 2013 Sundance Film Festival. He has since co-written and directed the seventh film in the Rocky series, Creed (2015), and the Marvel Cinematic Universe film Black Panther (2018), the latter of which became the highest domestic opening for a film directed by an African American Director.' )");

            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Steven S'," +
                "'DeKnight'," +
                "'Steven S. DeKnight (born April 8, 1964) is an American screenwriter, television producer, and director. He is best known for being the creator, head writer, and executive producer of the Starz series Spartacus, including Spartacus: Blood and Sand,[1] Spartacus: Gods of the Arena, Spartacus: Vengeance, and Spartacus: War of the Damned.' )");


            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Roar'," +
                "'Uthaug'," +
                "'Roar Uthaug (born August 25, 1973)[1] is a Norwegian film director. He graduated from the Norwegian Film School in 2002.' )");

            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Eli Raphael'," +
                "'Roth'," +
                "'Eli Raphael Roth (born April 18, 1972) is an American film director, producer, writer, and actor. As a director and producer, he is most closely associated with the horror genre, first coming to prominence by directing the 2005 film Hostel and its 2007 sequel, Hostel: Part II. As an actor, his most prominent role was as Donny The Bear Jew Donowitz in Quentin Tarantino''s war film Inglourious Basterds for which he won both a SAG Award (Best Ensemble) and a BFCA Critic''s Choice Award (Best Acting Ensemble).' )");



            Sql("INSERT INTO Directors (Name,Surname,Biography) VALUES ( " +
                "'Todd '," +
                "'Phillips'," +
                "'Todd Phillips (born Todd Bunzl;[1] December 20, 1970) is a Jewish American film director, producer, screenwriter and actor. He is best known for writing and directing Road Trip (2000), Old School (2003), Starsky & Hutch (2004), The Hangover Trilogy (2009, 2011, and 2013), Due Date (2010) and War Dogs (2016)' )");

        }

        public override void Down()
        {
        }
    }
}
