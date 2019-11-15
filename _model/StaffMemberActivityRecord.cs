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
  public class StaffMemberActivityRecord {
    /// <summary>
    /// Gets or Sets WorkplaceId
    /// </summary>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets OperationPhase
    /// </summary>
    [DataMember(Name="operationPhase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationPhase")]
    public string OperationPhase { get; set; }

    /// <summary>
    /// Gets or Sets TimePeriod
    /// </summary>
    [DataMember(Name="timePeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timePeriod")]
    public TimePeriodDefinition TimePeriod { get; set; }

    /// <summary>
    /// Gets or Sets Proportion
    /// </summary>
    [DataMember(Name="proportion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "proportion")]
    public double? Proportion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StaffMemberActivityRecord {\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  OperationPhase: ").Append(OperationPhase).Append("\n");
      sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
      sb.Append("  Proportion: ").Append(Proportion).Append("\n");
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
