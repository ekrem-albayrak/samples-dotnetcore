using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using RestSharp;
using FORCAM.BridgeAPI.Model;

namespace logic
{

    public class TokenHandler
    {
        private readonly string _user;
        private readonly string _password;
        private readonly string _baseURLForTokenGeneration;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="urlToAPI">/ffwebservices/api/v1/</param>
        /// <param name="urlForTokenGeneration">:24080/ffwebservices/</param>
        public TokenHandler(string user, string password, string urlForTokenGeneration)
        {
            _user = user;
            _password = password;
            _baseURLForTokenGeneration = urlForTokenGeneration;
        }
                
        /// <summary>
        /// Get access token
        /// </summary>
        /// <returns></returns>
        public Token GetAccessToken()
        {
            var httpClient = new RestClient(_baseURLForTokenGeneration);
            RestRequest request = new RestRequest("oauth2.0/accessToken?client_id=" + _user + "&client_secret=" + _password + "&grant_type=client_credentials&scope=read%20write", Method.GET, DataFormat.Json);
            var response = httpClient.Execute<Token>(request, Method.GET);
            return response.Data;
        }

    }
}
