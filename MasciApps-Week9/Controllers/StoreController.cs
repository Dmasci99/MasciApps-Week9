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
        MusicStoreEntities storeDB = new MusicStoreEntities(); //Gain access to all our Table Info

        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=jazz
        public ActionResult Browse(string genre)
        {
            //Genre genreModel = new Genre(genre);
            //return View(genreModel);
            return View();
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