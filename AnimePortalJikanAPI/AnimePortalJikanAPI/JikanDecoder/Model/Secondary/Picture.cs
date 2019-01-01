using Newtonsoft.Json;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Secondary
{
	/// <summary>
	/// Picture model class.
	/// </summary>
	public class Picture
	{
		/// <summary>
		/// Url to small version of the picture.
		/// </summary>
		[JsonProperty(PropertyName = "small")]
		public string Small { get; set; }

		/// <summary>
		/// Url to large version of the picture.
		/// </summary>
		[JsonProperty(PropertyName = "large")]
		public string Large { get; set; }
	}
}