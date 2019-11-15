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
  public class SuccessorWSModel {
    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets TargetWaitTime
    /// </summary>
    [DataMember(Name="targetWaitTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWaitTime")]
    public long? TargetWaitTime { get; set; }

    /// <summary>
    /// Gets or Sets TargetMoveTime
    /// </summary>
    [DataMember(Name="targetMoveTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetMoveTime")]
    public long? TargetMoveTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SuccessorWSModel {\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  TargetWaitTime: ").Append(TargetWaitTime).Append("\n");
      sb.Append("  TargetMoveTime: ").Append(TargetMoveTime).Append("\n");
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
