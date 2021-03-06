﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Search
{
	/// <summary>
	/// Model class for result from searching characters.
	/// </summary>
	public class CharacterSearchResult
	{
		/// <summary>
		/// List of search results.
		/// </summary>
		[JsonProperty(PropertyName = "results")]
		public ICollection<CharacterSearchEntry> Results { get; set; }

		/// <summary>
		/// Index of the last page.
		/// </summary>
		[JsonProperty(PropertyName = "last_page")]
		public int? ResultLastPage { get; set; }
	}
}