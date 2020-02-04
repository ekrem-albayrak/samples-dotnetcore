using logic;
using System;

namespace getoperatingstates
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the get all operating states example!" + Environment.NewLine);

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine operating states ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var operatingStates = connector.GetOperatingStates();

            foreach (var state in operatingStates)
            {
                Console.WriteLine(String.Format("Operating state: {0}: {1} ({2}) with color {3}", state.Code, state.ShortDescription, state.Description, state.Color));
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }

    }
}
