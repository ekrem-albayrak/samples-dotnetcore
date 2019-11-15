using core.logic;
using core.objects;
using System;

namespace getavailableworkplaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the get all available workplaces sample!" + Environment.NewLine);

            string urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // Url to Bridge API
            string urlToBridgeAPI = urlForTokenGeneration + "api/v2/";
            string user = "GitHub"; // User
            string password = "GitHub"; // Password of the user

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(user, password, urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.access_token + Environment.NewLine);

            Connector connector = new Connector(urlToBridgeAPI, token);

            Console.WriteLine("Determine workplaces ..." + Environment.NewLine);

            var workplaces = connector.GetWorkplaces();

            foreach (var workplace in workplaces)
            {
                Console.WriteLine(String.Format("Id: {0}, Number: {1}, Description: {2}", workplace.Id, workplace.Number, workplace.Description));
            }

        }
    }
}
