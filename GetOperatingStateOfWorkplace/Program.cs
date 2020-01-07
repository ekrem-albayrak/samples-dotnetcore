using logic;
using System;

namespace getoperatingstateofworkplace
{
    class Program
    {
        
        private const string _urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the get current operating state of a workplace example!" + Environment.NewLine);

            string workplaceNumber = "R_WPL_04"; // YOUR WORKPLACE NUMBER

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine workplace " + workplaceNumber + "..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var workplace = connector.GetCurrentWorkplaceOperatingStateByWorkplaceNumber(workplaceNumber);

            Console.WriteLine(String.Format("Workplace: {0} ({1})", workplace.Number, workplace.Description));
            Console.WriteLine(String.Format("State: {2}: {1} (Id: {0})", workplace.OperatingState.Id, workplace.OperatingState.Description, workplace.OperatingState.Code));
        }
    }
}
