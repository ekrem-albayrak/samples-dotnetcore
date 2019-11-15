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
  public class ProductionResourceToolProperties {
    /// <summary>
    /// The item number
    /// </summary>
    /// <value>The item number</value>
    [DataMember(Name="itemNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemNumber")]
    public string ItemNumber { get; set; }

    /// <summary>
    /// The type
    /// </summary>
    /// <value>The type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The group
    /// </summary>
    /// <value>The group</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// The number
    /// </summary>
    /// <value>The number</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// The description
    /// </summary>
    /// <value>The description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The quantity
    /// </summary>
    /// <value>The quantity</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public float? Quantity { get; set; }

    /// <summary>
    /// The quantity unit
    /// </summary>
    /// <value>The quantity unit</value>
    [DataMember(Name="quantityUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantityUnit")]
    public string QuantityUnit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductionResourceToolProperties {\n");
      sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
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
