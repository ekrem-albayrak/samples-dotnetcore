using FORCAM.BridgeAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

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

        public MachineProperties GetMachineOfWorkplaceByNumber(string workplaceNumber)
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("machines?workplaceNumber=" + workplaceNumber, Method.GET, DataFormat.Json);
            SetTokenHeader(request);
            var response = httpClient.Execute<MachineCollection>(request, Method.GET);
            return response.Data.Embedded.Machines.First().Properties;
        }


        public List<OperatingStateProperties>  GetOperatingStates()
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("masterData/operatingStates", Method.GET, DataFormat.Json);
            SetTokenHeader(request);
            var response = httpClient.Execute<OperatingStateCollection>(request, Method.GET);
            return response.Data.Embedded.OperatingStates.Select(x => x.Properties).ToList();
        }

        public void DeleteCallback(string id)
        {
            var httpClient = new RestClient(_baseURL);
            RestRequest request = new RestRequest("callbacks/" + id, Method.DELETE);
            SetTokenHeader(request);
            httpClient.Execute<MachineCollection>(request, Method.DELETE);
        }

        public async void RegisterCallback(string callbackRegistrationJSON)
        {
            Uri uri = new Uri(_baseURL + "callbacks");
            using (HttpClient client = new HttpClient())
            { 
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token.Access_token);
                client.DefaultRequestHeaders
                        .Accept
                        .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders
                        .AcceptLanguage
                        .Add(new StringWithQualityHeaderValue("en-EN"));

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri)
                {
                    Content = new StringContent(callbackRegistrationJSON)
                };

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.SendAsync(request);
            }
        }

    }
}
