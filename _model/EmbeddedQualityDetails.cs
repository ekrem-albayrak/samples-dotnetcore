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
  public class EmbeddedQualityDetails {
    /// <summary>
    /// The quantity reasons
    /// </summary>
    /// <value>The quantity reasons</value>
    [DataMember(Name="quantityReasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityReasons")]
    public List<QualityDetail> QuantityReasons { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbeddedQualityDetails {\n");
      sb.Append("  QuantityReasons: ").Append(QuantityReasons).Append("\n");
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
