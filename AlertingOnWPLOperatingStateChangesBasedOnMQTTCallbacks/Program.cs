using logic;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AlertingOnWorkplaceOperatingStateChangeBasedOnMQTTCallbacks
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://virtualfactory.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user
        private const string _workplaceNumber = "R_WPL_04"; // YOUR WORKPLACE NUMBER
        private const string _operating_state_code_for_alarming = "999"; // The operating state for alarming

        static async Task Main()
        {
            Console.WriteLine("Welcome to the alerting example (based on mqtt callbacks)!");
            Console.WriteLine("");

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();
            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);

            Console.WriteLine("Connect to the Bridge API and get machineID of defined workplace " + _workplaceNumber);
            Console.WriteLine("");

            string machineID = connector.GetMachineOfWorkplaceByNumber(_workplaceNumber).Id;

            Console.WriteLine("Machine id of workplace " + _workplaceNumber + " is " + machineID);
            Console.WriteLine("");

            // Register Callback on Bridge API

            string MQTTTCPUrl = "mqtt://test.mosquitto.org"; //Define your MQTT-Broker and topic!!!!
            string PORT = "1883";
            string MQTTTopicName = "external/statechange";
            string eventName = "MACHINE_STATE";

            Console.WriteLine("Register callback " + eventName + " of machine " + machineID + " for MQTT-Broker " + MQTTTCPUrl + ", topic " + MQTTTopicName);
            Console.WriteLine("");

            string callbackRegistrationJSON = BuildCallbackRegistrationJSON(MQTTTCPUrl + ":" + PORT + "/" + MQTTTopicName, machineID, eventName);
            connector.RegisterCallback(callbackRegistrationJSON);

            Console.WriteLine("Registration completed.");
            Console.WriteLine("");

            // Inizialize a MQTT-Client and subscribe to the above defined topic

            Console.WriteLine("Initialize a MQTT Client and subscripe to the given topic " + MQTTTopicName + "...");
            Console.WriteLine("");

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(MQTTTCPUrl.Replace("mqtt://", String.Empty), 1883)
                .Build();

            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();
            await mqttClient.ConnectAsync(options, CancellationToken.None);

            // Subscribe to the defined topic
            await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic(MQTTTopicName).Build());

            Console.WriteLine("Wait for machine state changes ...");
            Console.WriteLine("");

            List<string> callbackIDs = new List<string>();
            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine("---------------------------------------");
                try
                {
                    // WILL BE EXECUTED IF A MACHINE STATE OCCURES
                    var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                    var callbackResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<MACHINESTATECallbackJSONRespone>(payload);
                    if (!callbackIDs.Contains(callbackResponse.Properties.CallbackId)) callbackIDs.Add(callbackResponse.Properties.CallbackId);

                    Console.WriteLine("--- RECEIVED " + eventName + " MESSAGE ---");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("MachineId: " + callbackResponse.Properties.ObjectId);
                    Console.WriteLine("Time stamp: " + callbackResponse.Properties.Timestamp);
                    //There was a state change, now check if the current state is the wished "alarming"-statem if yes print out a "WARNING"
                    var workplace = connector.GetCurrentWorkplaceOperatingStateByWorkplaceNumber(_workplaceNumber);
                    if (workplace.OperatingState.Code == _operating_state_code_for_alarming)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("  !!! WARNING WARNING WARNING WARNING !!!");
                        Console.WriteLine(" --- MACHINE SWITCHED TO STATE CODE " + _operating_state_code_for_alarming + " ---");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(" !!! ERROR OCCURED !!! ");
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");
            });
            Console.ReadLine();

            // DELETE THE CALLBACK
            Console.WriteLine("Delete the previous registered callback ...");
            foreach (var id in callbackIDs)
            {
                Console.WriteLine("Delete the callback with id" + id);
                connector.DeleteCallback(id);
            }


        }


        private static string BuildCallbackRegistrationJSON(string mqttURL, string machineID, string eventName)
        {
            var builder = new StringBuilder();
            builder.AppendLine("{");
            builder.AppendLine("  \"eventType\": \"COMMAND\",");
            builder.AppendLine("  \"eventName\": \"" + eventName + "\",");
            builder.AppendLine("  \"url\": \"" + mqttURL + "\",");
            builder.AppendLine("  \"maxRedeliveryAttempts\": 100,");
            builder.AppendLine("  \"maxUnconfirmedMessages\": 5000,");
            builder.AppendLine("  \"objectFilter\": [");
            builder.AppendLine("     {");
            builder.AppendLine("       \"name\": \"id\",");
            builder.AppendLine("       \"value\": \"" + machineID + "\"");
            builder.AppendLine("     }");
            builder.AppendLine("  ]");
            builder.AppendLine("}");
            return builder.ToString();
        }

    }

}

