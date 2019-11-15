using logic;
using System;

namespace getoperatingstateofworkplace
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the get current operating state of a workplace example!" + Environment.NewLine);

            string urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // Url to Bridge API
            string urlToBridgeAPI = urlForTokenGeneration + "api/v2/";
            string user = "GitHub"; // User
            string password = "GitHub"; // Password of the user

            string workplaceNumber = "R_WPL_04"; // YOUR WORKPLACE NUMBER

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(user, password, urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.access_token + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(urlToBridgeAPI, token);

            Console.WriteLine("Determine workplace " + workplaceNumber + "..." + Environment.NewLine);

            var workplace = connector.GetWorkplaceByNumber(workplaceNumber);

            Console.WriteLine(String.Format("Workplace: {1} ({2})", workplace.Id, workplace.Number, workplace.Description));
            Console.WriteLine(String.Format("State: {2}: {1} (Id: {0})", workplace.OperatingState.Id, workplace.OperatingState.Description, workplace.OperatingState.Code));
        }
    }
}
