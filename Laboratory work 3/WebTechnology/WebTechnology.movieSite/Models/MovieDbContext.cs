using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BusinessLogic.DbModels;

namespace WebTechnology.movieSite.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("name=DataBaseMovie")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Picture> Pictures { get; set; }

    }
}