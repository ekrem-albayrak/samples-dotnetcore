using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FORCAM.BridgeAPI.Model
{
    public partial class TicketActivityRemarkCollection
    {
        [JsonProperty("_embedded")]
        public TicketActivityRemarkEmbedded Embedded { get; set; }
    }

    public partial class TicketActivityRemarkEmbedded
    {
        [JsonProperty("remarks")]
        public List<TicketActivityRemark> Remarks { get; set; }
    }

    public partial class TicketActivityRemark
    {
        [JsonProperty("properties")]
        public TicketActivityRemarkProperties Properties { get; set; }
    }

    public partial class TicketActivityRemarkProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
    }

}
