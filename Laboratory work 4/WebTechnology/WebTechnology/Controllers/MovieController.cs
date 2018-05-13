using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using BusinessLogic.DbModels;
using WebTechnology.Models;

namespace WebTechnology.movieSite.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {

        private ApplicationDbContext _db;

        public MovieController()
        {
            _db = new ApplicationDbContext();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var model = _db.Movies.Include(m => m.Country).Include(m => m.Language).Include(m => m.Director);

            return View(model);
        }

        public ActionResult Details(Movie movie)
        {
            return View(movie);
        }

        public ActionResult Genre(string genre)
        {

            if (genre == "All")
            {
                var movieDb = _db.Movies.Include(m => m.Country).Include(m => m.Language).Include(m => m.Director);
                return View("Index", movieDb);
            }
            else
            {
                var movieDb = _db.Movies.Where(m => m.Genre1 == genre || m.Genre2 == genre || m.Genre3 == genre).
                    Include(m => m.Country).Include(m => m.Language).Include(m => m.Director);
                return View("Index", movieDb);
            }

        }


        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

    }
}