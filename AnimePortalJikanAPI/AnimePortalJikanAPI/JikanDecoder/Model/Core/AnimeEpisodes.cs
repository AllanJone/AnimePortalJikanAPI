using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Anime episodes list model class.
	/// </summary>
	public class AnimeEpisodes
	{
		/// <summary>
		/// Last page of episodes' list.
		/// </summary>
		[JsonProperty(PropertyName = "episodes_last_page")]
		public int EpisodesLastPage { get; set; }

		/// <summary>
		/// Anime's episode collection with basic information.
		/// </summary>
		[JsonProperty(PropertyName = "episodes")]
		public ICollection<AnimeEpisode> EpisodeCollection { get; set; }
	}
}