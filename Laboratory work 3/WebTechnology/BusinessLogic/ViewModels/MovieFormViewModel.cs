using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DbModels;

namespace BusinessLogic.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Director> Directors { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Language> Languages { get; set; }
    }
}
