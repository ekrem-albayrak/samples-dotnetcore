using logic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Data
{

    public class BridgeAPIConnectorService
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        public Task<List<Workplace>> GetAllWorkplaces()
        {
            return Task.FromResult(GetWorkplaces());
        }

        public Task<List<OperatingState>> GetAllOperatingStates()
        {
            return Task.FromResult(GetOperatingStates());
        }

        public Task<string> GetCurrentOperatingStateOfWorkplace(string workplaceNumber)
        {
            return Task.FromResult(GetOperatingStateOfWorkplace(workplaceNumber));
        }

        private string GetOperatingStateOfWorkplace(string workplaceNumber)
        {
            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine workplace operating state ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var operatingState = connector.GetCurrentWorkplaceOperatingStateByWorkplaceNumber(workplaceNumber);

            return operatingState.Description + " (" + operatingState.Code + ")";
        }

        private List<Workplace> GetWorkplaces() 
        {
            Console.WriteLine("Welcome to the get all available workplaces sample!" + Environment.NewLine);

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine workplaces ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var workplaces = connector.GetWorkplaces();

            var result = new List<Workplace>();
            foreach (var item in workplaces)
            {
                result.Add(new Workplace() { Id = item.Id, Number = item.Number, Description = item.Description, OperatingStateCode = item.OperatingState.Code, OperatingStateDescription = item.OperatingState.Description });
            }
            return result;
        }

        private List<OperatingState> GetOperatingStates()
        {
            Console.WriteLine("Welcome to the get all operating states example!" + Environment.NewLine);

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine operating states ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var states = connector.GetOperatingStates();

            var result = new List<OperatingState>();
            foreach (var item in states)
            {
                result.Add(new OperatingState() { Code = item.Code, Description = item.Description, Color = item.Color, ShortDescription = item.ShortDescription });
            }
            return result;

        }



    }
}
