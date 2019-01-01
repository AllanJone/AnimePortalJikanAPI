using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Model class for anime top.
	/// </summary>
    public class AnimeTop
	{
		/// <summary>
		/// Collection of anime entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public ICollection<AnimeTopEntry> Top { get; set; }
    }
}
