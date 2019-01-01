using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// Character's picture model class.
	/// </summary>
	public class CharacterPictures
	{
		/// <summary>
		/// Character's extra image URLs.
		/// </summary>
		[JsonProperty(PropertyName = "pictures")]
		public ICollection<Picture> Pictures { get; set; }
	}
}