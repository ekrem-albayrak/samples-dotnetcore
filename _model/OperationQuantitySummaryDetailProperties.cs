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
  public class OperationQuantitySummaryDetailProperties {
    /// <summary>
    /// Gets or Sets WorkplaceId
    /// </summary>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// Gets or Sets Quantities
    /// </summary>
    [DataMember(Name="quantities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantities")]
    public Quantities Quantities { get; set; }

    /// <summary>
    /// Gets or Sets UnconfirmedQuantities
    /// </summary>
    [DataMember(Name="unconfirmedQuantities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unconfirmedQuantities")]
    public Quantities UnconfirmedQuantities { get; set; }

    /// <summary>
    /// Gets or Sets TotalQuantity
    /// </summary>
    [DataMember(Name="totalQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalQuantity")]
    public double? TotalQuantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationQuantitySummaryDetailProperties {\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  Quantities: ").Append(Quantities).Append("\n");
      sb.Append("  UnconfirmedQuantities: ").Append(UnconfirmedQuantities).Append("\n");
      sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
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
