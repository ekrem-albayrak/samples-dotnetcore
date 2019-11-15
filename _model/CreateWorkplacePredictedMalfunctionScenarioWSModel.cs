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
  public class CreateWorkplacePredictedMalfunctionScenarioWSModel {
    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<ImminentMalfunction> Elements { get; set; }

    /// <summary>
    /// The person or system who has created the malfunction scenario
    /// </summary>
    /// <value>The person or system who has created the malfunction scenario</value>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public string Creator { get; set; }

    /// <summary>
    /// The start date of the forecast horizon
    /// </summary>
    /// <value>The start date of the forecast horizon</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The end date of the forecast horizon
    /// </summary>
    /// <value>The end date of the forecast horizon</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateWorkplacePredictedMalfunctionScenarioWSModel {\n");
      sb.Append("  Elements: ").Append(Elements).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
