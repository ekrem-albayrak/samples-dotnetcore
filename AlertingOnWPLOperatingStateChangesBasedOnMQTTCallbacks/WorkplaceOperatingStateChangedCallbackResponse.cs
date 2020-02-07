using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AlertingOnWorkplaceOperatingStateChangeBasedOnMQTTCallbacks
{

    public partial class WorkplaceOperatingStateChangedCallbackResponse
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

    }

    public partial class Properties
    {
        [JsonProperty("callbackId")]
        public string CallbackId { get; set; }

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("eventName")]
        public object EventName { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("currentOperatingState")]
        public OperatingState CurrentOperatingState { get; set; }

        [JsonProperty("previousWorkplaceStateId")]
        public string PreviousWorkplaceStateId { get; set; }

        [JsonProperty("previousOperatingState")]
        public OperatingState PreviousOperatingState { get; set; }

        [JsonProperty("currentWorkplaceStateId")]
        public string CurrentWorkplaceStateId { get; set; }
    }

    public partial class OperatingState
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("workplaceStateId")]
        public string WorkplaceStateId { get; set; }
    }

}
