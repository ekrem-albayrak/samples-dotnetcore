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
  public class EmbeddedOperatingStates {
    /// <summary>
    /// The operating states
    /// </summary>
    /// <value>The operating states</value>
    [DataMember(Name="statusDefinitions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDefinitions")]
    public List<OperatingState> StatusDefinitions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbeddedOperatingStates {\n");
      sb.Append("  StatusDefinitions: ").Append(StatusDefinitions).Append("\n");
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
