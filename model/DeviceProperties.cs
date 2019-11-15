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
  public class DeviceProperties {
    /// <summary>
    /// The Id in FORCE to identify a device
    /// </summary>
    /// <value>The Id in FORCE to identify a device</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name of the device (e.g. S7 1212C DC), which could also be an abstract device (e.g. Welding 247)
    /// </summary>
    /// <value>The name of the device (e.g. S7 1212C DC), which could also be an abstract device (e.g. Welding 247)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A description of the device (e.g. SIMATIC S7-1200, CPU 1212C, 24 V DC) , which could also be an abstract device (e.g. Welding 247)
    /// </summary>
    /// <value>A description of the device (e.g. SIMATIC S7-1200, CPU 1212C, 24 V DC) , which could also be an abstract device (e.g. Welding 247)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Workplace
    /// </summary>
    [DataMember(Name="workplace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplace")]
    public WorkplaceGeneralDefinition Workplace { get; set; }

    /// <summary>
    /// Gets or Sets RecordedPhysicalQuantities
    /// </summary>
    [DataMember(Name="recordedPhysicalQuantities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recordedPhysicalQuantities")]
    public List<RecordedPhysicalQuantitiesWSModel> RecordedPhysicalQuantities { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeviceProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Workplace: ").Append(Workplace).Append("\n");
      sb.Append("  RecordedPhysicalQuantities: ").Append(RecordedPhysicalQuantities).Append("\n");
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
