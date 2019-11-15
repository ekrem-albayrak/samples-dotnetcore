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
  public class ImminentMalfunction {
    /// <summary>
    /// UUID of the workplace
    /// </summary>
    /// <value>UUID of the workplace</value>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// The UUID of the detailed operating state describing the machine malfunction
    /// </summary>
    /// <value>The UUID of the detailed operating state describing the machine malfunction</value>
    [DataMember(Name="operatingStateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingStateId")]
    public string OperatingStateId { get; set; }

    /// <summary>
    /// The date from which the probability of the machine malfunction increases significantly
    /// </summary>
    /// <value>The date from which the probability of the machine malfunction increases significantly</value>
    [DataMember(Name="prewarningDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prewarningDate")]
    public DateTime? PrewarningDate { get; set; }

    /// <summary>
    /// The date from which the machine malfunction is highly likely to occur
    /// </summary>
    /// <value>The date from which the machine malfunction is highly likely to occur</value>
    [DataMember(Name="criticalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "criticalDate")]
    public DateTime? CriticalDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImminentMalfunction {\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  OperatingStateId: ").Append(OperatingStateId).Append("\n");
      sb.Append("  PrewarningDate: ").Append(PrewarningDate).Append("\n");
      sb.Append("  CriticalDate: ").Append(CriticalDate).Append("\n");
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
