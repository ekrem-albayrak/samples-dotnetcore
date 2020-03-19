using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FORCAM.BridgeAPI.Model
{
    public partial class TicketActivityCollection
    {
        [JsonProperty("_embedded")]
        public TicketActivityEmbedded Embedded { get; set; }

    }

    public partial class TicketActivityEmbedded
    {
        [JsonProperty("activities")]
        public List<TicketActivity> Activities { get; set; }
    }

    public partial class TicketActivity
    {
        public TicketActivityProperties Properties { get; set; }
    }

    public partial class TicketActivityProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("ticketActivityStateId")]
        public string TicketActivityStateId { get; set; }

        [JsonProperty("dueDate")]
        public DateTimeOffset DueDate { get; set; }
    }

}
