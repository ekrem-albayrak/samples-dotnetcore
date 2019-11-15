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
  public class RecordedOperationPhase {
    /// <summary>
    /// Workplace ID of the workplace.
    /// </summary>
    /// <value>Workplace ID of the workplace.</value>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// UUID of the respective operation.
    /// </summary>
    /// <value>UUID of the respective operation.</value>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }

    /// <summary>
    /// Operation phase.
    /// </summary>
    /// <value>Operation phase.</value>
    [DataMember(Name="operationPhaseId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationPhaseId")]
    public string OperationPhaseId { get; set; }

    /// <summary>
    /// Start date and time of the operation phase.
    /// </summary>
    /// <value>Start date and time of the operation phase.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date and time of the operation phase.
    /// </summary>
    /// <value>End date and time of the operation phase.</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecordedOperationPhase {\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  OperationPhaseId: ").Append(OperationPhaseId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
