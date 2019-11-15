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
  public class QualityType {
    /// <summary>
    /// HAL embedded objects
    /// </summary>
    /// <value>HAL embedded objects</value>
    [DataMember(Name="_embedded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embedded")]
    public Object Embedded { get; set; }

    /// <summary>
    /// HAL link objects
    /// </summary>
    /// <value>HAL link objects</value>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Object Links { get; set; }

    /// <summary>
    /// The operation quantity type properties
    /// </summary>
    /// <value>The operation quantity type properties</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public QualityTypeProperties Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QualityType {\n");
      sb.Append("  Embedded: ").Append(Embedded).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
