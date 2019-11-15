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
  public class ShiftTypeProperties {
    /// <summary>
    /// The Id in FORCE to identify a shift type
    /// </summary>
    /// <value>The Id in FORCE to identify a shift type</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Description of the shift type
    /// </summary>
    /// <value>Description of the shift type</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Short description of the shift type
    /// </summary>
    /// <value>Short description of the shift type</value>
    [DataMember(Name="shortDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortDescription")]
    public string ShortDescription { get; set; }

    /// <summary>
    /// Is this a working shift type
    /// </summary>
    /// <value>Is this a working shift type</value>
    [DataMember(Name="isWorkingShift", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWorkingShift")]
    public bool? IsWorkingShift { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShiftTypeProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
      sb.Append("  IsWorkingShift: ").Append(IsWorkingShift).Append("\n");
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
