using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Model class for anime top.
	/// </summary>
	public class MangaTop
	{
		/// <summary>
		/// Collection of anime entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public ICollection<MangaTopEntry> Top { get; set; }
	}
}