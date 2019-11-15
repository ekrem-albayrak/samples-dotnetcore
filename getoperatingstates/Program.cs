using logic;
using System;
using System.Drawing;

namespace getoperatingstates
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the get all operating states example!" + Environment.NewLine);

            string urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // Url to Bridge API
            string urlToBridgeAPI = urlForTokenGeneration + "api/v2/";
            string user = "GitHub"; // User
            string password = "GitHub"; // Password of the user

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(user, password, urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine operating states ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(urlToBridgeAPI, token);
            var operatingStates = connector.GetOperatingStates();

            foreach (var state in operatingStates)
            {
                Console.WriteLine(String.Format("Operating state: {0}: {1} ({2}) with color {3}", state.Code, state.ShortDescription, state.Description, state.Color));
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }

    }
}
