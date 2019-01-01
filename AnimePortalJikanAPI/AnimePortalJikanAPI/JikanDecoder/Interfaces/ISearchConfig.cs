using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePortalJikanAPI.JikanDecoder.Interfaces
{
    /// <summary>
    /// Interface of search config for advanced searching.
    /// </summary>
    public interface ISearchConfig
    {
        /// <summary>
		/// Create query from current parameters for search request.
		/// </summary>
		/// <returns>Query from current parameters for search request</returns>
		string ConfigToString();
    }
}
