using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FORCAM.BridgeAPI.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CallbackProperties {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ObjectFilter
    /// </summary>
    [DataMember(Name="objectFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectFilter")]
    public List<CallbackObjectFilter> ObjectFilter { get; set; }

    /// <summary>
    /// The event type for which callbacks shall be sent
    /// </summary>
    /// <value>The event type for which callbacks shall be sent</value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// The event name for which callbacks shall be sent
    /// </summary>
    /// <value>The event name for which callbacks shall be sent</value>
    [DataMember(Name="eventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventName")]
    public string EventName { get; set; }

    /// <summary>
    /// The url which will be called by the callback
    /// </summary>
    /// <value>The url which will be called by the callback</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Max number of redeliver attempts
    /// </summary>
    /// <value>Max number of redeliver attempts</value>
    [DataMember(Name="maxRedeliverAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxRedeliverAttempts")]
    public int? MaxRedeliverAttempts { get; set; }

    /// <summary>
    /// Max number of unconfirmed messages
    /// </summary>
    /// <value>Max number of unconfirmed messages</value>
    [DataMember(Name="maxUnconfirmedMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxUnconfirmedMessages")]
    public int? MaxUnconfirmedMessages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CallbackProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ObjectFilter: ").Append(ObjectFilter).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  MaxRedeliverAttempts: ").Append(MaxRedeliverAttempts).Append("\n");
      sb.Append("  MaxUnconfirmedMessages: ").Append(MaxUnconfirmedMessages).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
