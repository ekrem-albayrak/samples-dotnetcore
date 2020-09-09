using FORCAM.BridgeAPI.Model;
using logic;
using System;

namespace getoperatingstateofworkplace
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:25443/ffauth/";
        private const string _urlToBridgeAPI = "https://forcebridgehackathon.force.eco:24443/ffwebservices/api/v3/";
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
            var workplace = connector.GetWorkplaceByNumber(workplaceNumber);

            Console.WriteLine(String.Format("Workplace: {0} ({1})", workplace.Number, workplace.Description));
            Console.WriteLine(String.Format("State: {2}: {1} (Id: {0})", workplace.OperatingState.Id, workplace.OperatingState.Description, workplace.OperatingState.Code));
        }
    }
}
