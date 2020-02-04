using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

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
        /// This method uses the OAuth Client Credentials Flow to get an Access Token to provide
        /// Authorization to the APIs.
        /// </summary>
        /// <returns></returns>
        public Token GetAccessToken()
        {
            var baseUri = new Uri(_baseURLForTokenGeneration);
            var encodedConsumerKey = HttpUtility.UrlEncode(_user);
            var encodedConsumerKeySecret = HttpUtility.UrlEncode(_password);
            var encodedPair = Base64Encode(String.Format("{0}:{1}", encodedConsumerKey, encodedConsumerKeySecret));

            var requestToken = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(baseUri, "oauth/token"),
                Content = new StringContent("grant_type=client_credentials")
            };

            requestToken.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded") { CharSet = "UTF-8" };
            requestToken.Headers.TryAddWithoutValidation("Authorization", String.Format("Basic {0}", encodedPair));

            HttpResponseMessage bearerResult;
            using (var client = new HttpClient())
            {
                bearerResult = client.SendAsync(requestToken).Result;
            }

            var bearerData = bearerResult.Content.ReadAsStringAsync().Result;
            return JObject.Parse(bearerData).ToObject<Token>();
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}
