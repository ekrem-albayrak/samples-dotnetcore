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
  public class OperationPhaseCollectionProperties {
    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets SetupPhaseDuration
    /// </summary>
    [DataMember(Name="setupPhaseDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupPhaseDuration")]
    public long? SetupPhaseDuration { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingPhaseDuration
    /// </summary>
    [DataMember(Name="processingPhaseDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingPhaseDuration")]
    public long? ProcessingPhaseDuration { get; set; }

    /// <summary>
    /// Gets or Sets ExecutionTime
    /// </summary>
    [DataMember(Name="executionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionTime")]
    public long? ExecutionTime { get; set; }

    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<RecordedOperationPhase> Elements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationPhaseCollectionProperties {\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  SetupPhaseDuration: ").Append(SetupPhaseDuration).Append("\n");
      sb.Append("  ProcessingPhaseDuration: ").Append(ProcessingPhaseDuration).Append("\n");
      sb.Append("  ExecutionTime: ").Append(ExecutionTime).Append("\n");
      sb.Append("  Elements: ").Append(Elements).Append("\n");
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
