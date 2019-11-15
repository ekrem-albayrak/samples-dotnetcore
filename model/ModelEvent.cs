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
  public class ModelEvent {
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public Object Data { get; set; }

    /// <summary>
    /// The name of the event
    /// </summary>
    /// <value>The name of the event</value>
    [DataMember(Name="eventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventName")]
    public string EventName { get; set; }

    /// <summary>
    /// The type of the event
    /// </summary>
    /// <value>The type of the event</value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// Gets or Sets ObjectId
    /// </summary>
    [DataMember(Name="objectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectId")]
    public string ObjectId { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public string ObjectType { get; set; }

    /// <summary>
    /// The timestamp when the event occured
    /// </summary>
    /// <value>The timestamp when the event occured</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelEvent {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
