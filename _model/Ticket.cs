using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FORCAM.BridgeAPI.Model
{
    public class TicketMaterial
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        public new string ToString()
        {
            return String.Format("Id: {1}, Number: {0}, Description: {2}", Number, Id, Description);
        }
    }

    public class TicketWorkplace
    {

        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [DataMember(Name = "erpContextId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erpContextId")]
        public string ErpContextId { get; set; }

        public new string ToString()
        {
            return String.Format("Id: {1}, Number: {0}, Description: {2}", Number, Id, Description);
        }
    }

    public class TicketProperties
    {

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [DataMember(Name = "rootCause", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rootCause")]
        public string RootCause { get; set; }

        [DataMember(Name = "priority", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        [DataMember(Name = "editor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editor")]
        public string Editor { get; set; }

        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "ticketStateId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ticketStateId")]
        public string TicketStateId { get; set; }

        [DataMember(Name = "ticketClassId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ticketClassId")]
        public string TicketClassId { get; set; }

        [DataMember(Name = "operationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public TicketMaterial Material { get; set; }

        [DataMember(Name = "workplace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplace")]
        public TicketWorkplace Workplace { get; set; }

        [DataMember(Name = "shiftId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shiftId")]
        public string ShiftId { get; set; }
    }

    public class Ticket
    {

        [DataMember(Name = "properties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "properties")]
        public TicketProperties Properties { get; set; }
    }

    public class TicketCollectionEmbedded
    {

        [DataMember(Name = "tickets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tickets")]
        public List<Ticket> Tickets { get; set; }
    }

    public class TicketCollection
    {

        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_embedded")]
        public TicketCollectionEmbedded Embedded { get; set; }
    }

}
