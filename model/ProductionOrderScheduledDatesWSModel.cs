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
  public class ProductionOrderScheduledDatesWSModel {
    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledDates
    /// </summary>
    [DataMember(Name="scheduledDates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledDates")]
    public OperationScheduledDatesProperties ScheduledDates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductionOrderScheduledDatesWSModel {\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  ScheduledDates: ").Append(ScheduledDates).Append("\n");
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
