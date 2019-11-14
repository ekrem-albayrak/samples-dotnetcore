using core.logic;
using core.objects;
using System;

namespace authentication
{
    class authentication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the authentication sample!" + Environment.NewLine);


            string urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // Url to Bridge API
            string user = "GitHub"; // User
            string password = "GitHub"; // Password of the user

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(user, password, urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Result:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Token: " + token.access_token);
            Console.WriteLine("Token type: " + token.token_type);
            Console.WriteLine("Expires in: " + token.expires_in);
            Console.WriteLine("Scope: " + token.scope);


        }
    }
}
