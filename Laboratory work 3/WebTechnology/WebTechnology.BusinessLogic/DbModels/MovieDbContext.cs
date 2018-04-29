using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTechnology.BusinessLogic.DbModel;

namespace WebTechnology.BusinessLogic.DbModels
{
    class MovieDbContext : DbContext
    {

        public MovieDbContext() : base("name=DatabaseMovie")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }

}
