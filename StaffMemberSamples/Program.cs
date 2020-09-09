using FORCAM.BridgeAPI.Model;
using logic;
using System;
using System.Linq;

namespace GetStaffMembers
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:25443/ffauth/";
        private const string _urlToBridgeAPI = "https://forcebridgehackathon.force.eco:24443/ffwebservices/api/v3/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user
        private const string _workplaceId = "DE77E02F7C814297883B0FBAF9FBA5A8";

        static void Main()
        {
            Console.WriteLine("Welcome to the staff members sample!" + Environment.NewLine);

            Console.WriteLine("Determine token ...");

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine staff members ...");

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var staffMembers = connector.GetStaffMembers();

            foreach (var staff in staffMembers)
            {
                Console.WriteLine(String.Format("Staff member: {0}: {2} {1}", staff.Id, staff.FirstName, staff.LastName));
            }
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Determine current staff members of workplace id " + _workplaceId + " ...");

            var currentStaffMembersOfWorkplace = connector.GetCurrentStaffMembersOfWorkplaceId(_workplaceId);
            foreach (var staff in currentStaffMembersOfWorkplace)
            {
                Console.WriteLine(String.Format("Staff member: {0}: {2} {1}", staff.Id, staff.FirstName, staff.LastName));
            }

            if (!currentStaffMembersOfWorkplace.Any())
            {
                Console.WriteLine("No staff member signed on!" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Sign off all staff members of workplace id " + _workplaceId + " ...");
                foreach (var staff in currentStaffMembersOfWorkplace)
                {
                    Console.WriteLine(String.Format("Sign off staff member: {0}: {2} {1}", staff.Id, staff.FirstName, staff.LastName));
                    connector.SendCommand(GetStaffMemberWorkplaceStateCommandString(SignOptions.Off, _workplaceId, staff.Id));
                }
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Determine current staff members of workplace id " + _workplaceId + " ...");
                currentStaffMembersOfWorkplace = connector.GetCurrentStaffMembersOfWorkplaceId(_workplaceId);
                foreach (var staff in currentStaffMembersOfWorkplace)
                {
                    Console.WriteLine(String.Format("Staff member: {0}: {2} {1}", staff.Id, staff.FirstName, staff.LastName));
                }
                if (!currentStaffMembersOfWorkplace.Any())
                {
                    Console.WriteLine("No staff member signed on!");
                }
                Console.WriteLine(Environment.NewLine);
            }


            Console.WriteLine("Sign on a staff member on workplace " + _workplaceId + " ...");
            var staffMemberToSignOn = staffMembers[new Random().Next(staffMembers.Count)];
            Console.WriteLine(String.Format("Sign on staff member: {0}: {2} {1}", staffMemberToSignOn.Id, staffMemberToSignOn.FirstName, staffMemberToSignOn.LastName));
            connector.SendCommand(GetStaffMemberWorkplaceStateCommandString(SignOptions.On, _workplaceId, staffMemberToSignOn.Id));

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Determine current staff members of workplace id " + _workplaceId + " ...");
            currentStaffMembersOfWorkplace = connector.GetCurrentStaffMembersOfWorkplaceId(_workplaceId);
            foreach (var staff in currentStaffMembersOfWorkplace)
            {
                Console.WriteLine(String.Format("Staff member: {0}: {2} {1}", staff.Id, staff.FirstName, staff.LastName));
            }

        }

        private enum SignOptions
        {
            On,
            Off
        }

        private static string GetStaffMemberWorkplaceStateCommandString(SignOptions signOptions, string workplaceID, string staffMemberID)
        {
            var action = "SIGNED_ON";
            if (signOptions == SignOptions.Off) action = "SIGNED_OFF";
            return "{" +
                  " \"workplaceId\": \"" + workplaceID + "\", " +
                  " \"staffMemberId\": \"" + staffMemberID + "\", " +
                  " \"staffMemberStateId\": \"" + action + "\", " +
                  " \"type\": \"STAFF_MEMBER_WORKPLACE_STATE\" " +
                  "}";
        }

    }
}
