using logic;
using System;
using System.Threading;

namespace AlertingOnWorkplaceOperationStateChangeCyclic
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user
        private const string _workplaceNumber = "R_WPL_04"; // YOUR WORKPLACE NUMBER
        private const string _operating_state_code_for_alarming = "999"; // The operating state for alarming

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the alerting example (cyclic)!" + Environment.NewLine);

            int cycleTime = 60000; // 60 seconds
            if (args != null && args.Length > 0)
            {
                cycleTime = Convert.ToInt32(args[0]); // Console parameter for cycle time
            }
            Console.WriteLine("Cycle time is " + (cycleTime / 1000) + " seconds!" + Environment.NewLine);

            Console.WriteLine("Start: " + Environment.NewLine);
            
            using Timer t = new Timer(TimerCallback, null, 0, cycleTime);
            {
                // Wait for the user to hit <Enter>
                Console.ReadLine();
            }

        }

        /// <summary>
        /// Will be executed after XX (cylce time)
        /// </summary>
        /// <param name="o"></param>
        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.WriteLine(DateTime.Now + ": ");

            var isWorkplaceInStateStoppageUndefined = IsWorkplaceInState(_workplaceNumber, _operating_state_code_for_alarming);
            if (isWorkplaceInStateStoppageUndefined)
            {
                // WARNING MESSAGE
                Console.WriteLine(String.Format("WARNING: Operating state {0} (Undefined Stoppage) occured on workplace {1}", _operating_state_code_for_alarming, _workplaceNumber));
            }
            else 
            {
                // Nothing to do
                Console.WriteLine("Everything is okay ...");
            }

            Console.WriteLine(String.Empty); // new line
        }

   

        private static bool IsWorkplaceInState(string workplaceNumber, string operatingStateCode)
        {
            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();
            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);
            var workplace = connector.GetWorkplaceByNumber(workplaceNumber);
            return (workplace.OperatingState.Code == operatingStateCode);
        }

    }
}
