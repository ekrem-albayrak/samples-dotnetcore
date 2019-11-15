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
  public class CreateToolOrderProperties {
    /// <summary>
    /// Target workplace ID
    /// </summary>
    /// <value>Target workplace ID</value>
    [DataMember(Name="targetWorkplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWorkplaceId")]
    public string TargetWorkplaceId { get; set; }

    /// <summary>
    /// Operation id
    /// </summary>
    /// <value>Operation id</value>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateToolOrderProperties {\n");
      sb.Append("  TargetWorkplaceId: ").Append(TargetWorkplaceId).Append("\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
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
