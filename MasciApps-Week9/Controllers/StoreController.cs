using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasciApps_Week9.Models;

namespace MasciApps_Week9.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre("Disco"),
                new Genre("Jazz"),
                new Genre("Rock")
            };
            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=jazz
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            Album album = new Album {
                Title = "Album " + id
            };
            return View(album);
        }
    }
}