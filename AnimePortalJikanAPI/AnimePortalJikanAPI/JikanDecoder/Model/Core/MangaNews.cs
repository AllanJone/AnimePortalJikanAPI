using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Manga news list model class.
	/// </summary>
	public class MangaNews
	{
		/// <summary>
		/// News related to manga.
		/// </summary>
		[JsonProperty(PropertyName = "articles")]
		public ICollection<News> News { get; set; }
	}
}