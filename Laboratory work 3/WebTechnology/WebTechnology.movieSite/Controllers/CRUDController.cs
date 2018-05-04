using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.DbModels;
using WebTechnology.movieSite.Models;
using BusinessLogic.ViewModels;

namespace WebTechnology.movieSite.Controllers
{
    public class CRUDController : Controller
    {
        private MovieDbContext _db;

        public CRUDController()
        {
            _db = new MovieDbContext();
        }



        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieForm()
        {
            var directors = _db.Directors.ToList();
            var countries = _db.Countries.ToList();
            var languages = _db.Languages.ToList();
            var model = new MovieFormViewModel()
            {
                Movie = new Movie(),
                Directors = directors,
                Countries = countries,
                Languages = languages
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie )
        {
            //check if model is valid
            if (!ModelState.IsValid)
            {
                var model = new MovieFormViewModel()
                {
                    Movie = movie,
                    Directors = _db.Directors.ToList(),
                    Countries = _db.Countries.ToList(),
                    Languages = _db.Languages.ToList()
                };
                return View("MovieForm", model);

            }
            // save
            if (movie.Id == 0)
            {
                _db.Movies.Add(movie);
            }
            // edit
            else
            {
                var movieFromDb = _db.Movies.Single(m => m.Id == movie.Id);
                movieFromDb.Title = movie.Title;
                movieFromDb.PicturePath = movie.PicturePath;
                movieFromDb.Duration = movie.Duration;
                movieFromDb.RealeseDate = movie.RealeseDate;
                movieFromDb.Raiting = movie.Raiting;
                movieFromDb.Free = movie.Free;
                movieFromDb.Description = movie.Description;
                movieFromDb.Genre1 = movie.Genre1;
                movieFromDb.Genre2 = movie.Genre2;
                movieFromDb.Genre3 = movie.Genre3;
                movieFromDb.MoviePath = movie.MoviePath;
                movieFromDb.DirectorId = movie.DirectorId;
                movieFromDb.CountryId = movie.CountryId;
                movieFromDb.LanguageId = movie.LanguageId;

            }

            _db.SaveChanges();

            return RedirectToAction("Index", "CRUD");
        }

        public ActionResult ShowAllMovies()
        {
            var movies = _db.Movies.ToList();

            return View(movies);
        }

        public ActionResult Update(Movie movie)
        {
            var directors = _db.Directors.ToList();
            var countries = _db.Countries.ToList();
            var languages = _db.Languages.ToList();
            var model = new MovieFormViewModel()
            {
                Movie = movie,
                Directors = directors,
                Countries = countries,
                Languages = languages
            };

            return View("MovieForm",model);
        }


        public ActionResult Delete(Movie movie)
        {
            var movieFromDb = _db.Movies.Find(movie.Id);
            _db.Movies.Remove(movieFromDb);
            _db.SaveChanges();

            return RedirectToAction("ShowAllMovies", "CRUD");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}