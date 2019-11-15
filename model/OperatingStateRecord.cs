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
  public class OperatingStateRecord {
    /// <summary>
    /// Gets or Sets OperatingState
    /// </summary>
    [DataMember(Name="operatingState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingState")]
    public OperatingStateGeneralDefinition OperatingState { get; set; }

    /// <summary>
    /// Gets or Sets TimePeriod
    /// </summary>
    [DataMember(Name="timePeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timePeriod")]
    public TimePeriodDefinition TimePeriod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperatingStateRecord {\n");
      sb.Append("  OperatingState: ").Append(OperatingState).Append("\n");
      sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
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
