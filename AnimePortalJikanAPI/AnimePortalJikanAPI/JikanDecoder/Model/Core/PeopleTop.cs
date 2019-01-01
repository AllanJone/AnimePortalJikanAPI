using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Model class for people top.
	/// </summary>
	public class PeopleTop
	{
		/// <summary>
		/// Collection of people entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public ICollection<PersonTopEntry> Top { get; set; }
	}
}