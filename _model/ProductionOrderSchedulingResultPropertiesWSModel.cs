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
  public class ProductionOrderSchedulingResultPropertiesWSModel {
    /// <summary>
    /// Gets or Sets ScheduledStartDate
    /// </summary>
    [DataMember(Name="scheduledStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledStartDate")]
    public DateTime? ScheduledStartDate { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledEndDate
    /// </summary>
    [DataMember(Name="scheduledEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledEndDate")]
    public DateTime? ScheduledEndDate { get; set; }

    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<ProductionOrderScheduledDatesWSModel> Elements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductionOrderSchedulingResultPropertiesWSModel {\n");
      sb.Append("  ScheduledStartDate: ").Append(ScheduledStartDate).Append("\n");
      sb.Append("  ScheduledEndDate: ").Append(ScheduledEndDate).Append("\n");
      sb.Append("  Elements: ").Append(Elements).Append("\n");
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
