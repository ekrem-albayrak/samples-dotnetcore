using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlertingOnWorkplaceOperatingStateChangeBasedOnMQTTCallbacks
{
    public class MACHINESTATECallbackJSONRespone
    {
        [JsonProperty("properties")]
        public MACHINESTATECallbackJSONResponeProperties Properties { get; set; }
    }

    public class MACHINESTATECallbackJSONResponeProperties
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("data")]
        public MACHINESTATECallbackJSONResponePropertiesData Data { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("eventName")]
        public string EventName { get; set; }
    }

    public class MACHINESTATECallbackJSONResponePropertiesData
    {
        [JsonProperty("machineId")]
        public string MachineId { get; set; }

        [JsonProperty("machineStateDetailIds")]
        public string[] MachineStateDetailIds { get; set; }

        [JsonProperty("machineStateId")]
        public string MachineStateId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
