using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Model class for most popular characters.
	/// </summary>
	public class CharactersTop
	{
		/// <summary>
		/// Collection of characters entries on top list.
		/// </summary>
		[JsonProperty(PropertyName = "top")]
		public ICollection<CharacterTopEntry> Top { get; set; }
	}
}