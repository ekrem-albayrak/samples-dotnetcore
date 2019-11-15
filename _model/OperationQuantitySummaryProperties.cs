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
  public class OperationQuantitySummaryProperties {
    /// <summary>
    /// The performance rate during the entire execution of the operation. If the operation is still being executed, this property might be 0
    /// </summary>
    /// <value>The performance rate during the entire execution of the operation. If the operation is still being executed, this property might be 0</value>
    [DataMember(Name="performance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performance")]
    public double? Performance { get; set; }

    /// <summary>
    /// The quality rate during the entire execution of the operation. If the operation is still being executed, this property might be 0
    /// </summary>
    /// <value>The quality rate during the entire execution of the operation. If the operation is still being executed, this property might be 0</value>
    [DataMember(Name="qualityRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qualityRate")]
    public double? QualityRate { get; set; }

    /// <summary>
    /// Gets or Sets Material
    /// </summary>
    [DataMember(Name="material", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material")]
    public Material Material { get; set; }

    /// <summary>
    /// Gets or Sets TotalQuantity
    /// </summary>
    [DataMember(Name="totalQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalQuantity")]
    public double? TotalQuantity { get; set; }

    /// <summary>
    /// The unit of the output quantity
    /// </summary>
    /// <value>The unit of the output quantity</value>
    [DataMember(Name="quantityUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityUnit")]
    public string QuantityUnit { get; set; }

    /// <summary>
    /// The target time per unit in msec
    /// </summary>
    /// <value>The target time per unit in msec</value>
    [DataMember(Name="targetTimePerUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetTimePerUnit")]
    public string TargetTimePerUnit { get; set; }

    /// <summary>
    /// Gets or Sets TimePerUnit
    /// </summary>
    [DataMember(Name="timePerUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timePerUnit")]
    public double? TimePerUnit { get; set; }

    /// <summary>
    /// Gets or Sets ProductionTime
    /// </summary>
    [DataMember(Name="productionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionTime")]
    public long? ProductionTime { get; set; }

    /// <summary>
    /// Gets or Sets Elements
    /// </summary>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<OperationQuantitySummaryDetailProperties> Elements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationQuantitySummaryProperties {\n");
      sb.Append("  Performance: ").Append(Performance).Append("\n");
      sb.Append("  QualityRate: ").Append(QualityRate).Append("\n");
      sb.Append("  Material: ").Append(Material).Append("\n");
      sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
      sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
      sb.Append("  TargetTimePerUnit: ").Append(TargetTimePerUnit).Append("\n");
      sb.Append("  TimePerUnit: ").Append(TimePerUnit).Append("\n");
      sb.Append("  ProductionTime: ").Append(ProductionTime).Append("\n");
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
