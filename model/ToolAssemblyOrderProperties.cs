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
  public class ToolAssemblyOrderProperties {
    /// <summary>
    /// The Id in FORCE to identify a tool order
    /// </summary>
    /// <value>The Id in FORCE to identify a tool order</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The created timestamp of a tool order
    /// </summary>
    /// <value>The created timestamp of a tool order</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

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
    /// The tool assembly state of the tool order
    /// </summary>
    /// <value>The tool assembly state of the tool order</value>
    [DataMember(Name="toolAssemblyOrderStateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toolAssemblyOrderStateId")]
    public string ToolAssemblyOrderStateId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ToolAssemblyOrderProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  TargetWorkplaceId: ").Append(TargetWorkplaceId).Append("\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  ToolAssemblyOrderStateId: ").Append(ToolAssemblyOrderStateId).Append("\n");
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
