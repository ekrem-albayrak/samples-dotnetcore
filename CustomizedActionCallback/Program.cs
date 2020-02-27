using logic;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CustomizedActionCallback
{
    class Program
    {

        private const string _urlForTokenGeneration = "https://forcebridgehackathon.force.eco:24443/ffwebservices/"; // URL to Bridge API
        private const string _urlToBridgeAPI = _urlForTokenGeneration + "api/v2/";
        private const string _user = "GitHub"; // User
        private const string _password = "GitHub"; // Password of the user
        private const string _workplaceNumber = "R_WPL_04"; // YOUR WORKPLACE NUMBER
        private const string _operating_state_code_for_alarming = "999"; // The operating state for alarming

        static async Task Main()
        {
            Console.WriteLine("Welcome to the Customized Action Callback Sample");
            Console.WriteLine("");

            TokenHandler tokenHandler = new TokenHandler(_user, _password, _urlForTokenGeneration);
            Token token = tokenHandler.GetAccessToken();
            FORCEBridgeConnector connector = new FORCEBridgeConnector(_urlToBridgeAPI, token);

            // Register Callback on Bridge API

            string MQTTTCPUrl = "mqtt://test.mosquitto.org"; //Define your MQTT-Broker and topic!!!!
            string PORT = "1883";
            string MQTTTopicName = "external/forcecustomcallback";
            string EventType = "CUSTOMIZED_ACTION_TRIGGERED";
            string ForceCustomEventName = "test";

            Console.WriteLine("Register callback " + EventType + " for MQTT-Broker " + MQTTTCPUrl + ", topic " + MQTTTopicName);
            Console.WriteLine("");

            string callbackRegistrationJSON = BuildCallbackRegistrationJSON(MQTTTCPUrl + ":" + PORT + "/" + MQTTTopicName, EventType, ForceCustomEventName);
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

            Console.WriteLine("Wait for customited actions ...");
            Console.WriteLine("");

            List<string> callbackIDs = new List<string>();
            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine("---------------------------------------");
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Console.WriteLine("--- RECEIVED " + EventType + " MESSAGE ---");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(Newtonsoft.Json.Linq.JObject.Parse(payload).SelectToken("properties.data").ToString());
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");
                string callbackId = Newtonsoft.Json.Linq.JObject.Parse(payload).SelectToken("properties.callbackId").ToString();
                if (!callbackIDs.Contains(callbackId)) callbackIDs.Add(callbackId);
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


        private static string BuildCallbackRegistrationJSON(string mqttURL, string eventType, string forceEventName)
        {
            var builder = new StringBuilder();
            builder.AppendLine("{");
            builder.AppendLine("  \"eventType\": \"" + eventType + "\","); // CUSTOMIZED_ACTION_TRIGGERED
            builder.AppendLine("  \"eventName\": \"" + forceEventName + "\","); // The name of configurated event in force
            builder.AppendLine("  \"url\": \"" + mqttURL + "\",");
            builder.AppendLine("  \"maxRedeliveryAttempts\": 100,");
            builder.AppendLine("  \"maxUnconfirmedMessages\": 5000");
            builder.AppendLine("}");
            return builder.ToString();
        }

    }

}

