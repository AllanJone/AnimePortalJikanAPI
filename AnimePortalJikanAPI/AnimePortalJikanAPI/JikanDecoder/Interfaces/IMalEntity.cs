using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePortalJikanAPI.JikanDecoder.Interfaces
{
    /// <summary>
	/// Interface for MAL entities with their own Id.
	/// </summary>
    public interface IMalEntity
    {
        /// <summary>
		/// ID associated with MyAnimeList.
		/// </summary>
		long MalId { get; set; }
    }
}
