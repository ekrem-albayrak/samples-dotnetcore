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
  public class RecordedOutputQuantities {
    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets BookingTime
    /// </summary>
    [DataMember(Name="bookingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingTime")]
    public DateTime? BookingTime { get; set; }

    /// <summary>
    /// Gets or Sets QualityTypeId
    /// </summary>
    [DataMember(Name="qualityTypeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityTypeId")]
    public string QualityTypeId { get; set; }

    /// <summary>
    /// Gets or Sets QualityDetailId
    /// </summary>
    [DataMember(Name="qualityDetailId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityDetailId")]
    public string QualityDetailId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RecordedOutputQuantities {\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  BookingTime: ").Append(BookingTime).Append("\n");
      sb.Append("  QualityTypeId: ").Append(QualityTypeId).Append("\n");
      sb.Append("  QualityDetailId: ").Append(QualityDetailId).Append("\n");
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
