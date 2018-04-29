using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTechnology.movieSite.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Sign_up()
        {
            return View();
        }

        public ActionResult Sign_in()
        {
            return View();
        }
    }
}