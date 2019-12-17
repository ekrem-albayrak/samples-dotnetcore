using logic;
using System;

namespace getavailableworkplaces
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the get all available workplaces sample!" + Environment.NewLine);

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine workplaces ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var workplaces = connector.GetWorkplaces();

            foreach (var workplace in workplaces)
            {
                Console.WriteLine(String.Format("Id: {0}, Number: {1}, Description: {2}", workplace.Id, workplace.Number, workplace.Description));
            }

        }
    }
}
