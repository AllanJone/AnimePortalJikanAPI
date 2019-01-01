using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// User's anime list model class.
	/// </summary>
	public class UserAnimeList
	{
		/// <summary>
		/// Collection of user's anime on their anime list.
		/// </summary>
		[JsonProperty(PropertyName = "anime")]
		public ICollection<AnimeListEntry> Anime { get; set; }
	}
}