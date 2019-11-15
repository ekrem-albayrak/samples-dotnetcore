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
  public class FileRepositoryDocumentProperties {
    /// <summary>
    /// The ID in FORCE to identify an nc element
    /// </summary>
    /// <value>The ID in FORCE to identify an nc element</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Extension
    /// </summary>
    [DataMember(Name="extension", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension")]
    public string Extension { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public long? Size { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public string Creator { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Editor
    /// </summary>
    [DataMember(Name="editor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editor")]
    public string Editor { get; set; }

    /// <summary>
    /// Gets or Sets LastChangedDate
    /// </summary>
    [DataMember(Name="lastChangedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastChangedDate")]
    public DateTime? LastChangedDate { get; set; }

    /// <summary>
    /// Gets or Sets LastTransferToMachine
    /// </summary>
    [DataMember(Name="lastTransferToMachine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransferToMachine")]
    public DateTime? LastTransferToMachine { get; set; }

    /// <summary>
    /// Gets or Sets LastTransferedFromWorkplaceId
    /// </summary>
    [DataMember(Name="lastTransferedFromWorkplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransferedFromWorkplaceId")]
    public string LastTransferedFromWorkplaceId { get; set; }

    /// <summary>
    /// Gets or Sets LastTransferedToWorkplaceId
    /// </summary>
    [DataMember(Name="lastTransferedToWorkplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransferedToWorkplaceId")]
    public string LastTransferedToWorkplaceId { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfMachineTransfers
    /// </summary>
    [DataMember(Name="numberOfMachineTransfers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfMachineTransfers")]
    public long? NumberOfMachineTransfers { get; set; }

    /// <summary>
    /// Gets or Sets DocumentStateId
    /// </summary>
    [DataMember(Name="documentStateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentStateId")]
    public string DocumentStateId { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileRepositoryDocumentProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Extension: ").Append(Extension).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Editor: ").Append(Editor).Append("\n");
      sb.Append("  LastChangedDate: ").Append(LastChangedDate).Append("\n");
      sb.Append("  LastTransferToMachine: ").Append(LastTransferToMachine).Append("\n");
      sb.Append("  LastTransferedFromWorkplaceId: ").Append(LastTransferedFromWorkplaceId).Append("\n");
      sb.Append("  LastTransferedToWorkplaceId: ").Append(LastTransferedToWorkplaceId).Append("\n");
      sb.Append("  NumberOfMachineTransfers: ").Append(NumberOfMachineTransfers).Append("\n");
      sb.Append("  DocumentStateId: ").Append(DocumentStateId).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
