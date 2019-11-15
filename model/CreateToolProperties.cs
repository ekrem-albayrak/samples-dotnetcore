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
  public class CreateToolProperties {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the tool
    /// </summary>
    /// <value>The description of the tool</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// First part of the tool identifier
    /// </summary>
    /// <value>First part of the tool identifier</value>
    [DataMember(Name="identifier1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier1")]
    public string Identifier1 { get; set; }

    /// <summary>
    /// Second part of the tool identifier
    /// </summary>
    /// <value>Second part of the tool identifier</value>
    [DataMember(Name="identifier2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier2")]
    public string Identifier2 { get; set; }

    /// <summary>
    /// Third part of the tool identifier
    /// </summary>
    /// <value>Third part of the tool identifier</value>
    [DataMember(Name="identifier3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier3")]
    public string Identifier3 { get; set; }

    /// <summary>
    /// A url which links to a page with more information about the tool
    /// </summary>
    /// <value>A url which links to a page with more information about the tool</value>
    [DataMember(Name="documentUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentUrl")]
    public string DocumentUrl { get; set; }

    /// <summary>
    /// The tool group id
    /// </summary>
    /// <value>The tool group id</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public ToolIdentifierValue Group { get; set; }

    /// <summary>
    /// The tool class id
    /// </summary>
    /// <value>The tool class id</value>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public ToolIdentifierValue _Class { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public ToolLocationGeneralDefinition Location { get; set; }

    /// <summary>
    /// Gets or Sets Characteristics
    /// </summary>
    [DataMember(Name="characteristics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characteristics")]
    public List<CharacteristicGeneralDefinition> Characteristics { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateToolProperties {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Identifier1: ").Append(Identifier1).Append("\n");
      sb.Append("  Identifier2: ").Append(Identifier2).Append("\n");
      sb.Append("  Identifier3: ").Append(Identifier3).Append("\n");
      sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  _Class: ").Append(_Class).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
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
