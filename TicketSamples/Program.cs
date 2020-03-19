using FORCAM.BridgeAPI.Model;
using logic;
using System;
using System.Linq;

namespace getoperatingstates
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:25443/ffauth/";
        private const string _urlToBridgeAPI = "https://forcebridgehackathon.force.eco:24443/ffwebservices/api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user

        static void Main()
        {
            Console.WriteLine("Welcome to the ticket sample!" + Environment.NewLine);

            Console.WriteLine("Determine token ..." + Environment.NewLine);

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();

            Console.WriteLine("Token: " + token.Access_token + Environment.NewLine);

            Console.WriteLine("Determine all tickets ..." + Environment.NewLine);

            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var tickets = connector.GetTickets();

            int counter = 0;
            foreach (TicketProperties ticket in tickets)
            {
                counter += 1;
                Console.WriteLine(String.Empty);
                Console.WriteLine("Ticket " + counter + " of " + tickets.Count);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Id: {0}", ticket.Id);
                Console.WriteLine("Number: {0}", ticket.Number);
                Console.WriteLine("Title: {0}", ticket.Title);
                Console.WriteLine("Description: {0}", ticket.Description);
                Console.WriteLine("RootCause: {0}", ticket.RootCause);
                Console.WriteLine("Priority: {0}", ticket.Priority);
                Console.WriteLine("Editor: {0}", ticket.Editor);
                Console.WriteLine("CreationDate: {0}", ticket.CreationDate);
                Console.WriteLine("TicketStateId: {0}", ticket.TicketStateId);
                Console.WriteLine("TicketClassId: {0}", ticket.TicketClassId);
                Console.WriteLine("OperationId: {0}", ticket.OperationId);
                Console.WriteLine("Material: {0}", (ticket.Material is null) ? "" : ticket.Material.ToString());
                Console.WriteLine("Workplace: {0}", (ticket.Workplace is null) ? "" : ticket.Workplace.ToString());
                Console.WriteLine("ShiftId: {0}", ticket.ShiftId);

            }

            Console.WriteLine(String.Empty);
            Console.WriteLine("Determine all activities of ticket {0} ..." + Environment.NewLine, tickets.First().Id);

            var ticketActivities = connector.GetTicketActivitiesByTicketId(tickets.First().Id);


            counter = 0;
            foreach (TicketActivityProperties activity in ticketActivities)
            {
                counter += 1;
                Console.WriteLine(String.Empty);
                Console.WriteLine("Ticket activity " + counter + " of " + ticketActivities.Count);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Id: {0}", activity.Id);
                Console.WriteLine("Title: {0}", activity.Title);
                Console.WriteLine("State: {0}", activity.TicketActivityStateId);
                Console.WriteLine("Editor: {0}", activity.Editor);
                Console.WriteLine("Due date: {0}", activity.DueDate);
                Console.WriteLine("Description: {0}", activity.Description);
            }
            Console.WriteLine(String.Empty);


            Console.WriteLine(String.Empty);
            Console.WriteLine("Determine all remmarks of activity {0} (ticket {1}) ..." + Environment.NewLine, tickets.First().Id, ticketActivities.First().Id);

            var ticketActivityRemarks = connector.GetTicketActivityRemarksByTicketAndActivityId(tickets.First().Id, ticketActivities.First().Id);
            counter = 0;
            foreach (TicketActivityRemarkProperties remark in ticketActivityRemarks)
            {
                counter += 1;
                Console.WriteLine(String.Empty);
                Console.WriteLine("Ticket activity remark " + counter + " of " + ticketActivityRemarks.Count);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Id: {0}", remark.Id);
                Console.WriteLine("Editor: {0}", remark.Editor);
                Console.WriteLine("Remark: {0}", remark.Remark);
            }
            Console.WriteLine(String.Empty);
        }

    }
}
