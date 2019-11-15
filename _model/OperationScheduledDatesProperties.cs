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
  public class OperationScheduledDatesProperties {
    /// <summary>
    /// Earliest start date
    /// </summary>
    /// <value>Earliest start date</value>
    [DataMember(Name="earliestStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliestStartDate")]
    public DateTime? EarliestStartDate { get; set; }

    /// <summary>
    /// Latest start date
    /// </summary>
    /// <value>Latest start date</value>
    [DataMember(Name="latestStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestStartDate")]
    public DateTime? LatestStartDate { get; set; }

    /// <summary>
    /// Earliest end date
    /// </summary>
    /// <value>Earliest end date</value>
    [DataMember(Name="earliestEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliestEndDate")]
    public DateTime? EarliestEndDate { get; set; }

    /// <summary>
    /// Latest end date
    /// </summary>
    /// <value>Latest end date</value>
    [DataMember(Name="latestEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestEndDate")]
    public DateTime? LatestEndDate { get; set; }

    /// <summary>
    /// Scheduled start date
    /// </summary>
    /// <value>Scheduled start date</value>
    [DataMember(Name="scheduledStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledStartDate")]
    public DateTime? ScheduledStartDate { get; set; }

    /// <summary>
    /// Scheduled end date
    /// </summary>
    /// <value>Scheduled end date</value>
    [DataMember(Name="scheduledEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledEndDate")]
    public DateTime? ScheduledEndDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationScheduledDatesProperties {\n");
      sb.Append("  EarliestStartDate: ").Append(EarliestStartDate).Append("\n");
      sb.Append("  LatestStartDate: ").Append(LatestStartDate).Append("\n");
      sb.Append("  EarliestEndDate: ").Append(EarliestEndDate).Append("\n");
      sb.Append("  LatestEndDate: ").Append(LatestEndDate).Append("\n");
      sb.Append("  ScheduledStartDate: ").Append(ScheduledStartDate).Append("\n");
      sb.Append("  ScheduledEndDate: ").Append(ScheduledEndDate).Append("\n");
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
