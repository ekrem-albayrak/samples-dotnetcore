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
  public class CreateToolEdgeProperties {
    /// <summary>
    /// The tool edge identifier
    /// </summary>
    /// <value>The tool edge identifier</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets LifeTime
    /// </summary>
    [DataMember(Name="lifeTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lifeTime")]
    public LifeTime LifeTime { get; set; }

    /// <summary>
    /// The tool edge characteristics
    /// </summary>
    /// <value>The tool edge characteristics</value>
    [DataMember(Name="characteristics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characteristics")]
    public List<CharacteristicGeneralDefinition> Characteristics { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateToolEdgeProperties {\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
      sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
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
