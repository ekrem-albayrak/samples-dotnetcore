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
  public class WpOperatingStateSummaryPropertiesWSModel {
    /// <summary>
    /// Sum of the durations of all operating states which belong to the time base SCHEDULED_OPERATING_TIME.
    /// </summary>
    /// <value>Sum of the durations of all operating states which belong to the time base SCHEDULED_OPERATING_TIME.</value>
    [DataMember(Name="scheduledOperatingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledOperatingTime")]
    public long? ScheduledOperatingTime { get; set; }

    /// <summary>
    /// Gets or Sets OccupancyTime
    /// </summary>
    [DataMember(Name="occupancyTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occupancyTime")]
    public long? OccupancyTime { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingTime
    /// </summary>
    [DataMember(Name="processingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingTime")]
    public long? ProcessingTime { get; set; }

    /// <summary>
    /// Production time of a workplace.
    /// </summary>
    /// <value>Production time of a workplace.</value>
    [DataMember(Name="productionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionTime")]
    public long? ProductionTime { get; set; }

    /// <summary>
    /// Setup time of a workplace.
    /// </summary>
    /// <value>Setup time of a workplace.</value>
    [DataMember(Name="setupTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupTime")]
    public long? SetupTime { get; set; }

    /// <summary>
    /// Gets or Sets OccupancyRate
    /// </summary>
    [DataMember(Name="occupancyRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occupancyRate")]
    public double? OccupancyRate { get; set; }

    /// <summary>
    /// Gets or Sets SetupReduction
    /// </summary>
    [DataMember(Name="setupReduction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupReduction")]
    public double? SetupReduction { get; set; }

    /// <summary>
    /// Gets or Sets ProcessAvailability
    /// </summary>
    [DataMember(Name="processAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processAvailability")]
    public double? ProcessAvailability { get; set; }

    /// <summary>
    /// Gets or Sets Availability
    /// </summary>
    [DataMember(Name="availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability")]
    public double? Availability { get; set; }

    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<RecordedOperatingStateSummary> Elements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WpOperatingStateSummaryPropertiesWSModel {\n");
      sb.Append("  ScheduledOperatingTime: ").Append(ScheduledOperatingTime).Append("\n");
      sb.Append("  OccupancyTime: ").Append(OccupancyTime).Append("\n");
      sb.Append("  ProcessingTime: ").Append(ProcessingTime).Append("\n");
      sb.Append("  ProductionTime: ").Append(ProductionTime).Append("\n");
      sb.Append("  SetupTime: ").Append(SetupTime).Append("\n");
      sb.Append("  OccupancyRate: ").Append(OccupancyRate).Append("\n");
      sb.Append("  SetupReduction: ").Append(SetupReduction).Append("\n");
      sb.Append("  ProcessAvailability: ").Append(ProcessAvailability).Append("\n");
      sb.Append("  Availability: ").Append(Availability).Append("\n");
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
