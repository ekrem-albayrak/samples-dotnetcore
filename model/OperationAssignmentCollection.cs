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
  public class OperationAssignmentCollection {
    /// <summary>
    /// HAL embedded objects
    /// </summary>
    /// <value>HAL embedded objects</value>
    [DataMember(Name="_embedded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embedded")]
    public Object Embedded { get; set; }

    /// <summary>
    /// Contains the linked resources: first,previous,next,last
    /// </summary>
    /// <value>Contains the linked resources: first,previous,next,last</value>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Object Links { get; set; }

    /// <summary>
    /// The collection properties
    /// </summary>
    /// <value>The collection properties</value>
    [DataMember(Name="pagination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pagination")]
    public CollectionProperties Pagination { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public OperationAssignmentCollectionProperties Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationAssignmentCollection {\n");
      sb.Append("  Embedded: ").Append(Embedded).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Pagination: ").Append(Pagination).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
