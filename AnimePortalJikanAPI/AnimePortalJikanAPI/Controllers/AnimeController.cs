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
        // GET: Anime
        public ActionResult Index()
        {
            /*List<Anime> animeList = new List<Anime>();
            IJikan jikan = new Jikan(true);
            Anime anime = jikan.GetAnime(1);
            AnimeTop topAnimeList = jikan.GetAnimeTop();
            foreach (AnimeTopEntry animeTopEntry in topAnimeList.Top)
            {
                Anime animeTemp = jikan.GetAnime(animeTopEntry.MalId);
                animeList.Add(animeTemp);
            }
            ViewData["animeName"] = anime.Title;*/

            //List<Anime> animeList = new List<Anime>();
            //IJikan jikan = new Jikan(true);
            //AnimeTop topAnimeList = jikan.GetAnimeTop(1);
            //foreach (AnimeTopEntry animeTopEntry in topAnimeList.Top)
            //{
            //    Anime animeTemp = jikan.GetAnime(animeTopEntry.MalId);
            //    animeList.Add(animeTemp);
            //}

            List<AnimeTopEntry> animeList = new List<AnimeTopEntry>();
            IJikan jikan = new Jikan(true);
            AnimeTop topAnimeList = jikan.GetAnimeTop(1);
            animeList = topAnimeList.Top.ToList();
            return View(animeList);
        }
    }
}