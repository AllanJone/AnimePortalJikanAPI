using AnimePortalJikanAPI.JikanDecoder.Consts;
using AnimePortalJikanAPI.JikanDecoder.Exceptions;
using AnimePortalJikanAPI.JikanDecoder.Helpers;
using AnimePortalJikanAPI.JikanDecoder.Interfaces;
using AnimePortalJikanAPI.JikanDecoder.Model.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace AnimePortalJikanAPI.JikanDecoder
{
    public class Jikan : IJikan

    {
        #region Field

        private readonly bool useHttps;

        private readonly bool surpressException;

        private readonly HttpClient httpClient;

        #endregion Field

        #region Properties

        /// <summary>
        /// End to which request will be send to.
        /// </summary>
        public string Endpoint
        {
            get
            {
                return this.useHttps ? HttpProvider.httpsEndpoint : HttpProvider.httpEndpoint;
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="useHttps">Should client send SSL encrypted requests.</param>
        /// <param name="surpressException">Should exception be thrown in case of failed request. If true, failed request return null.</param>
        public Jikan(bool useHttps, bool surpressException = true)
        {
            this.useHttps = useHttps;
            this.surpressException = surpressException;
            httpClient = HttpProvider.GetHttpClient(useHttps);
        }

        #endregion Constructors

        #region Anime methods

        #region GetAnime

        public Anime GetAnime(long id)
        {
            string[] endpointParts = new string[] { Endpoint, JikanEndPointCategories.Anime, id.ToString() };
            return ExecuteGetRequest<Anime>(endpointParts);
        }

        #endregion GetAnime

        #endregion Anime methods

        #region Top methods

        #region GetAnimeTop

        /// <summary>
        /// Return list of top anime.
        /// </summary>
        /// <returns>List of top anime.</returns>
        public AnimeTop GetAnimeTop()
        {
            string[] endpointParts = new string[] { Endpoint, JikanEndPointCategories.TopList, JikanEndPointCategories.Anime };
            return ExecuteGetRequest<AnimeTop>(endpointParts);
        }

        /// <summary>
        /// Return list of top anime.
        /// </summary>
        /// <param name="page">Indexx of page folding 50 records of top ranging (e.g. 1 will return first 50 records, 2 will return record from 51 to 100 etc.)</param>
        /// <returns>List of top anime.</returns>
        public AnimeTop GetAnimeTop(int page)
        {
            string[] endpointParts = new string[] { Endpoint, JikanEndPointCategories.TopList, JikanEndPointCategories.Anime, page.ToString() };
            return ExecuteGetRequest<AnimeTop>(endpointParts);
        }

        #endregion GetAnimeTop

        #endregion Top methods

        #region Private Methods

        /// <summary>
        /// Vasic method for handling requests and responses from endpoint.
        /// </summary>
        /// <typeparam name="T">Class type received from GET requests.</typeparam>
        /// <param name="args">Arguments building endpoint.</param>
        /// <returns>Requested object if successfull, null otherwise.</returns>
        private T ExecuteGetRequest<T>(string[] args) where T : class
        {
            T returnedObject = null;
            string requestUrl = String.Join("/", args);
            try
            {
                string json = "";
                var client = new HttpClient();
                var getDataTask = httpClient.GetAsync(requestUrl)
                    .ContinueWith(response =>
                    {
                        var result = response.Result;
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var responseData = result.Content.ReadAsStringAsync();
                            responseData.Wait();
                            json = responseData.Result;
                        }
                        else if (!surpressException)
                        {
                            throw new JikanRequestException();
                        }
                    });

                getDataTask.Wait();
                returnedObject = JsonConvert.DeserializeObject<T>(json);
            }
            catch (JsonSerializationException ex)
            {
                if (!surpressException)
                {
                    throw new JikanRequestException(ex.Message);
                }
            }
            return returnedObject;

            #endregion Private Methods
        }
    }
}