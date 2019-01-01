using AnimePortalJikanAPI.JikanDecoder.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePortalJikanAPI.JikanDecoder.Interfaces
{
    /// <summary>
	/// Interface for Jikan.net client
	/// </summary>
    public interface IJikan
    {
        /// <summary>
        /// Returns anime with given MAL id.
        /// </summary>
        /// <param name="id">MAL id of anime.</param>
        /// <returns>Anime with given MAL id.</returns>
        Anime GetAnime(long id);

        /// <summary>
        /// Returns list of top anime.
        /// </summary>
        /// <returns>List of top anime.</returns>
        AnimeTop GetAnimeTop();

        /// <summary>
        /// Returns list of top anime.
        /// </summary>
        /// <param name="page">Index of page folding 50 records of top ranging (e.g. 1 will return first 50 records, 2 will return record from 51 to 100 etc.)</param>
        /// <returns>List of top anime.</returns>
        AnimeTop GetAnimeTop(int page);
    }
}
