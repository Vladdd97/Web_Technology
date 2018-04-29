using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.DbModels;
using WebTechnology.movieSite.Models;

namespace WebTechnology.movieSite.Controllers
{
    public class HomeController : Controller
    {
        private MovieDbContext _db;

        public HomeController()
        {
            _db = new MovieDbContext();
        }



        // GET: Home
        public ActionResult Index()
        {
            var model = _db.Movies.Include(m => m.Country).Include(m => m.Language).Include(m => m.Director);

            return View(model);
        }



        public ActionResult About()
        {
            return Content("About .......... ");
        }



        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }


    }

}