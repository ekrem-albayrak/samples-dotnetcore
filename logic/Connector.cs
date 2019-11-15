using core.objects;
using FORCAM.BridgeAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace core.logic
{
    public class Connector
    {

        private string _baseURL;
        private Token _token;

        public Connector(string urlBridgeAPI, Token accessToken)
        {
            _baseURL = urlBridgeAPI;
            _token = accessToken;
        }

        private void SetTokenHeader(RestRequest request)
        {
            request.AddHeader("Accept-Language", "en-EN"); // Define the language of the results (de-DE, en-EN, ...)
            request.AddHeader("Accept", "application/hal+json;charset=UTF-8");
            request.AddHeader("Authorization", "Bearer " + _token.access_token) ;
        }

        public List<WorkplaceProperties>  GetWorkplaces()
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("workplaces", Method.GET, DataFormat.Json);
            SetTokenHeader(request);
            var response = httpClient.Execute<WorkplaceCollection>(request, Method.GET);
            return response.Data.Embedded.Workplaces.Select(x => x.Properties).ToList();
        }

        public WorkplaceProperties GetWorkplaceByNumber(string workplaceNumber)
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("workplaces?workplaceNumber=" + workplaceNumber, Method.GET, DataFormat.Json);
            SetTokenHeader(request);
            var response = httpClient.Execute<WorkplaceCollection>(request, Method.GET);
            return response.Data.Embedded.Workplaces.First().Properties;
        }

    }
}
