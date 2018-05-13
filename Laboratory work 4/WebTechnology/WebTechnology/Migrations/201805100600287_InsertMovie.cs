namespace WebTechnology.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Rampage','~/Content/images/Rampage.jpg',107,2018,800,1," +
                "'Athena-1, a research space station owned by gene manipulation company Energyne, is destroyed after a laboratory rat mutates and wreaks havoc. A crew member, Dr. Kerry Atkins, is ordered to retrieve research canisters containing a pathogen by CEO Claire Wyden. Atkins is able to flee in the escape pod, but it disintegrates upon re-entry, killing her and leaving a trail of debris across the United States, including the Everglades, where a canister is consumed by an American crocodile, and a forest in Wyoming, where a gray wolf is exposed to the pathogen.'," +
                "'Action','Adventure','~/Content/images/PlayMovie.png',1,1,1)");


            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Black Panther','~/Content/images/BlackPanther.jpg',134,2018,900,1," +
                "'After the events of Captain America: Civil War, King T''Challa returns home to the reclusive, technologically advanced African nation of Wakanda to serve as his country''s new leader. However, T''Challa soon finds that he is challenged for the throne from factions within his own country. When two foes conspire to destroy Wakanda, the hero known as Black Panther must team up with C.I.A. agent Everett K. Ross and members of the Dora Milaje, Wakandan special forces, to prevent Wakanda from being dragged into a world war.'," +
                "'Action','Adventure','~/Content/images/PlayMovie.png',2,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Pacific Rim: Uprising','~/Content/images/PacificRimUprising.jpg',111,2018,600,1," +
                "'Jake Pentecost, son of Stacker Pentecost, reunites with Mako Mori to lead a new generation of Jaeger pilots, including rival Lambert and 15-year-old hacker Amara, against a new Kaiju threat.'," +
                "'Action','Adventure','~/Content/images/PlayMovie.png',3,2,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Tomb Raider','~/Content/images/TombRaider.jpg',118,2018,450,1," +
                "'Lara Croft, the fiercely independent daughter of a missing adventurer, must push herself beyond her limits when she finds herself on the island where her father disappeared.'," +
                "'Action','Adventure','~/Content/images/PlayMovie.png',4,2,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Death Wish','~/Content/images/DeathWish.jpg',107,2018,250,1," +
                "'Dr. Paul Kersey is an experienced trauma surgeon, a man who has spent his life saving lives. After an attack on his family, Paul embarks on his own mission for justice.'," +
                "'Action','Crime','Drama','~/Content/images/PlayMovie.png',5,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'San Andreas','~/Content/images/SanAndreas.jpg',114,2015,720,1," +
                "'In the aftermath of a massive earthquake in California, a rescue-chopper pilot makes a dangerous journey across the state in order to rescue his daughter.'," +
                "'Action','Drama','Thriller','~/Content/images/PlayMovie.png',1,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Knock Knock','~/Content/images/KnockKnock.jpg',99,2015,310,1," +
                "'When a devoted husband and father is left home alone for the weekend, two stranded young women unexpectedly knock on his door for help. What starts out as a kind gesture results in a dangerous seduction and a deadly game of cat and mouse.'," +
                "'Horror','Mystery','Thriller','~/Content/images/PlayMovie.png',5,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hostel','~/Content/images/Hostel.jpg',94,2005,190,1," +
                "'3 backpackers are in Amsterdam where they get locked out of their youth hostel. They are invited into a man''s house where he tells them of a hostel somewhere in eastern Europe where the women are all incredibly hot and have a taste for American men. When they get there, everything is too good to be true - the hostel is to die fo'," +
                "'Horror','Mystery','Thriller','~/Content/images/PlayMovie.png',5,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hostel2','~/Content/images/Hostel2.jpg',93,2007,410,1," +
                "'Three female college students take a detour from their partying, enticed by a beautiful European woman who promises seclusion, safety and maybe even romance. What they get is a living hell where they are sold to the highest bidder who''s fondest wish is to kill them slowly. Hostel 2 also follows 2 American men who, on the flip side of the coin, are willing to pay to join an exclusive club where a life will end at their hands...any way they like. It''s a story of human monsters and the almighty dollar as only Eli Roth could tell it...'," +
                "'Horror','Mystery','Thriller','~/Content/images/PlayMovie.png',5,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,Genre2,Genre3,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hostel3','~/Content/images/Hostel3.jpg',88,2011,510,1," +
                "'While attending a bachelor party in Las Vegas, four friends are enticed by two sexy escorts to join them at a private party way off the Strip. Once there, they are horrified to find ...'," +
                "'Horror','Mystery','Thriller','~/Content/images/PlayMovie.png',5,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hangover','~/Content/images/Hangover.jpg',100,2009,910,1," +
                "'Angelenos Doug Billings and Tracy Garner are about to get married. Two days before the wedding, the four men in the wedding party - Doug, Doug''s two best buddies Phil Wenneck and Stu Price, and Tracy''s brother Alan Garner - hop into Tracy''s father''s beloved Mercedes convertible for a 24-hour stag party to Las Vegas. Phil, a married high school teacher, has the same maturity level as his students when he''s with his pals. Stu, a dentist, is worried about everything, especially what his controlling girlfriend Melissa thinks. And Alan seems to be unaware of what are considered the social graces of the western world...'," +
                "'Comedy','~/Content/images/PlayMovie.png',6,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hangover 2','~/Content/images/Hangover2.jpg',102,2011,905,1," +
                "'Stu is getting married. Along with Doug, Phil, and his soon-to-be brother-in-law Teddy, he regretfully invites Alan to Thailand for the wedding. After a quiet night on the beach with a beer and toasting marshmallows by the camp fire, Stu, Alan and Phil wake up in a seedy apartment in Bangkok. Doug is back at the resort, but Teddy is missing, there''s a monkey with a severed finger, Alan''s head is shaved, Stu has a tattoo on his face, and they can''t remember any of it. The wolf-pack retrace their steps through strip clubs, tattoo parlors and cocaine-dealing monkeys on the streets of Bangkok as they try and find Teddy before the wedding...'," +
                "'Comedy','~/Content/images/PlayMovie.png',6,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Hangover 3','~/Content/images/Hangover3.jpg',100,2013,910,1," +
                "'In the aftermath of the death of Alan''s father, the wolfpack decide to take Alan to get treated for his mental issues. But things start to go wrong on the way to the hospital as the wolfpack is assaulted and Doug is kidnapped. Now they must find Mr. Chow again in order to surrender him to the gangster who kidnapped Doug in order to save him...'," +
                "'Comedy','~/Content/images/PlayMovie.png',6,1,1)");

            Sql("INSERT INTO Movies (Title,PicturePath,Duration,RealeseDate," +
                "Raiting,Free,Description,Genre1,MoviePath," +
                "DirectorId,CountryId,LanguageId) " +
                "VALUES ( 'Due Date','~/Content/images/DueDate.jpg',95,2010,735,1," +
                "'High-strung father-to-be Peter Highman is forced to hitch a ride with aspiring actor Ethan Tremblay on a road trip in order to make it to his child''s birth on time.'," +
                "'Comedy','~/Content/images/PlayMovie.png',6,1,1)");
        }


        public override void Down()
        {
        }
    }
}
