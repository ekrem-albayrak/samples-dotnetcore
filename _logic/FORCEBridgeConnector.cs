using FORCAM.BridgeAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace logic
{
    public class FORCEBridgeConnector
    {

        private readonly string _baseURL;
        private readonly Token _token;

        public FORCEBridgeConnector(string urlBridgeAPI, Token accessToken)
        {
            _baseURL = urlBridgeAPI;
            _token = accessToken;
        }

        private void SetTokenHeader(RestRequest request)
        {
            request.AddHeader("Accept-Language", "en-EN"); // Define the language of the results (de-DE, en-EN, ...)
            request.AddHeader("Accept", "application/hal+json;charset=UTF-8");
            request.AddHeader("Authorization", "Bearer " + _token.Access_token) ;
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

        public List<OperatingStateProperties>  GetOperatingStates()
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("masterData/operatingStates", Method.GET, DataFormat.Json);
            SetTokenHeader(request);
            var response = httpClient.Execute<OperatingStateCollection>(request, Method.GET);
            return response.Data.Embedded.OperatingStates.Select(x => x.Properties).ToList();
        }

    }
}
