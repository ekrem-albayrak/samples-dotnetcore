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
  public class ProductionOrderOperationSequence {
    /// <summary>
    /// Gets or Sets Operation
    /// </summary>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public ProductionOrderOperation Operation { get; set; }

    /// <summary>
    /// Gets or Sets Predecessors
    /// </summary>
    [DataMember(Name="predecessors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predecessors")]
    public List<PredecessorWSModel> Predecessors { get; set; }

    /// <summary>
    /// Gets or Sets Successors
    /// </summary>
    [DataMember(Name="successors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successors")]
    public List<SuccessorWSModel> Successors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductionOrderOperationSequence {\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      sb.Append("  Predecessors: ").Append(Predecessors).Append("\n");
      sb.Append("  Successors: ").Append(Successors).Append("\n");
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
