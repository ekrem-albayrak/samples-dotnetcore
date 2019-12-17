using logic;
using System;

namespace authentication
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the authentication sample!");           
            Console.WriteLine("");

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Result:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Token: " + token.Access_token);
            Console.WriteLine("Token type: " + token.Token_type);
            Console.WriteLine("Expires in: " + token.Expires_in);
            Console.WriteLine("Scope: " + token.Scope);


        }
    }
}
