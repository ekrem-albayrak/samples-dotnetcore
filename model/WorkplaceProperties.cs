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
  public class WorkplaceProperties {
    /// <summary>
    /// UUID of the workplace 
    /// </summary>
    /// <value>UUID of the workplace </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The workplace number which is unique in its ERP context
    /// </summary>
    /// <value>The workplace number which is unique in its ERP context</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// A description of the workplace 
    /// </summary>
    /// <value>A description of the workplace </value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Universally unique identifier of the ERP context in which the workplace number is a unique identifier for a workplace or a workplace group. In SAP ERP, for example, this context is defined by the client, the company code, and the plant.
    /// </summary>
    /// <value>Universally unique identifier of the ERP context in which the workplace number is a unique identifier for a workplace or a workplace group. In SAP ERP, for example, this context is defined by the client, the company code, and the plant.</value>
    [DataMember(Name="erpContextId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "erpContextId")]
    public string ErpContextId { get; set; }

    /// <summary>
    /// The capacity group of the workplace
    /// </summary>
    /// <value>The capacity group of the workplace</value>
    [DataMember(Name="capacityGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacityGroup")]
    public WorkplaceGroupProperties CapacityGroup { get; set; }

    /// <summary>
    /// The production line of the workplace
    /// </summary>
    /// <value>The production line of the workplace</value>
    [DataMember(Name="productionLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionLine")]
    public WorkplaceGroupProperties ProductionLine { get; set; }

    /// <summary>
    /// Gets or Sets OperatingState
    /// </summary>
    [DataMember(Name="operatingState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingState")]
    public OperatingStateGeneralDefinition OperatingState { get; set; }

    /// <summary>
    /// Manual flag of the workplace 
    /// </summary>
    /// <value>Manual flag of the workplace </value>
    [DataMember(Name="isManualWorkplace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isManualWorkplace")]
    public bool? IsManualWorkplace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WorkplaceProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ErpContextId: ").Append(ErpContextId).Append("\n");
      sb.Append("  CapacityGroup: ").Append(CapacityGroup).Append("\n");
      sb.Append("  ProductionLine: ").Append(ProductionLine).Append("\n");
      sb.Append("  OperatingState: ").Append(OperatingState).Append("\n");
      sb.Append("  IsManualWorkplace: ").Append(IsManualWorkplace).Append("\n");
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
