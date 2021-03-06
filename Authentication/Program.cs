﻿using FORCAM.BridgeAPI.Model;
using logic;
using System;

namespace authentication
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:25443/ffauth/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the authentication sample!");
            Console.WriteLine("");

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Result ClientCredentials:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Token: " + token.Access_token);
            Console.WriteLine("Refresh-Token: " + token.Refresh_token);
            Console.WriteLine("Token type: " + token.Token_type);
            Console.WriteLine("Expires in: " + token.Expires_in);
            Console.WriteLine("Scope: " + token.Scope);

        }
    }
}
