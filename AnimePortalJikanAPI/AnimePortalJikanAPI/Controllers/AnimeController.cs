using AnimePortalJikanAPI.JikanDecoder;
using AnimePortalJikanAPI.JikanDecoder.Interfaces;
using AnimePortalJikanAPI.JikanDecoder.Model.Core;
using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimePortalJikanAPI.Controllers
{
    public class AnimeController : Controller
    {

        IJikan jikan = new Jikan(true);

        // GET: Anime
        public ActionResult Index()
        {
            List<AnimeTopEntry> animeList = new List<AnimeTopEntry>();
            AnimeTop topAnimeList = jikan.GetAnimeTop(1);
            animeList = topAnimeList.Top.ToList();
            return View(animeList);
        }

        public ActionResult Details(int id = 1)
        {
            Anime anime = jikan.GetAnime(id);
            return View(anime);
        }
    }
}