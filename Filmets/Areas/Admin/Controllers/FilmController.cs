using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmets.Areas.Admin.Controllers
{
    public class FilmController : Controller
    {
        [HttpGet]
        public ActionResult AddFilm()
        {

            return View();
        }
    }
}