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
  public class OperationPredictedValuesProperties {
    /// <summary>
    /// Gets or Sets ProcessingTimePerUnit
    /// </summary>
    [DataMember(Name="processingTimePerUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingTimePerUnit")]
    public double? ProcessingTimePerUnit { get; set; }

    /// <summary>
    /// Gets or Sets ScrapQuantity
    /// </summary>
    [DataMember(Name="scrapQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scrapQuantity")]
    public double? ScrapQuantity { get; set; }

    /// <summary>
    /// Gets or Sets SetupTime
    /// </summary>
    [DataMember(Name="setupTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupTime")]
    public long? SetupTime { get; set; }

    /// <summary>
    /// Gets or Sets Availability
    /// </summary>
    [DataMember(Name="availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availability")]
    public double? Availability { get; set; }

    /// <summary>
    /// Gets or Sets Performance
    /// </summary>
    [DataMember(Name="performance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performance")]
    public double? Performance { get; set; }

    /// <summary>
    /// Gets or Sets QualityRate
    /// </summary>
    [DataMember(Name="qualityRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityRate")]
    public double? QualityRate { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingTime
    /// </summary>
    [DataMember(Name="processingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingTime")]
    public long? ProcessingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationPredictedValuesProperties {\n");
      sb.Append("  ProcessingTimePerUnit: ").Append(ProcessingTimePerUnit).Append("\n");
      sb.Append("  ScrapQuantity: ").Append(ScrapQuantity).Append("\n");
      sb.Append("  SetupTime: ").Append(SetupTime).Append("\n");
      sb.Append("  Availability: ").Append(Availability).Append("\n");
      sb.Append("  Performance: ").Append(Performance).Append("\n");
      sb.Append("  QualityRate: ").Append(QualityRate).Append("\n");
      sb.Append("  ProcessingTime: ").Append(ProcessingTime).Append("\n");
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
