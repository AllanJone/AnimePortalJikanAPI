﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace AnimePortalJikanAPI.JikanDecoder.Helpers
{
    /// <summary>
    /// Provider class for static HttpClient.
    /// </summary>
    public static class HttpProvider
    {
        /// <summary>
        /// Endpoint for not SSL encrypted requests.
        /// </summary>
        public const string httpEndpoint = "http://api.jikan.moe/v3";

        /// <summary>
        /// Endpoint for SSL encrypted requests.
        /// </summary>
        public const string httpsEndpoint = "http://api.jikan.moe/v3";

        //TODO: Remove in 2019
        /// <summary>
        /// Temporary Endpoint for SSL encrypted requests .
        /// </summary>
        public const string temporaryHttpsEndpoint = "http://api.jikan.moe/v3";

        /// <summary>
        /// Static HttpClient.
        /// </summary>
        private static HttpClient Client { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        static HttpProvider()
        {
            Client = new HttpClient();
        }

        /// <summary>
        /// Get static HttpClient.
        /// </summary>
        /// <returns>Static HttpClient.</returns>
        public static HttpClient GetHttpClient(bool useHttps)
        {
            if (Client == null)
            {
                string endpoint = DateTime.Now.Year < 2019 ?
                    temporaryHttpsEndpoint :
                    useHttps ? httpsEndpoint : httpEndpoint;
                Client = new HttpClient
                {
                    BaseAddress = new Uri(endpoint)
                };
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }

            return Client;
        }

    }
}