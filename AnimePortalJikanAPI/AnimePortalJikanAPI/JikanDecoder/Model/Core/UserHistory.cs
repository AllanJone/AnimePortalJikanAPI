using AnimePortalJikanAPI.JikanDecoder.Model.Secondary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AnimePortalJikanAPI.JikanDecoder.Model.Core
{
	/// <summary>
	/// User's history model class.
	/// </summary>
	public class UserHistory
	{
		/// <summary>
		/// Collection of user's history updates.
		/// </summary>
		[JsonProperty(PropertyName = "history")]
		public ICollection<HistoryEntry> History { get; set; }
	}
}