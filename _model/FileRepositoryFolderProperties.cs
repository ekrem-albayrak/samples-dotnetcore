using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FileRepositoryFolderProperties
    {
        /// <summary>
        /// The ID in FORCE to identify a nc package
        /// </summary>
        /// <value>The ID in FORCE to identify a nc package</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets Editor
        /// </summary>
        [DataMember(Name = "editor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "editor")]
        public string Editor { get; set; }

        /// <summary>
        /// Gets or Sets LastChangeDate
        /// </summary>
        [DataMember(Name = "lastChangeDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastChangeDate")]
        public DateTime? LastChangeDate { get; set; }

        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public Material Material { get; set; }

        /// <summary>
        /// Gets or Sets Workplace
        /// </summary>
        [DataMember(Name = "workplace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplace")]
        public WorkplaceGeneralDefinition Workplace { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileRepositoryFolderProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  LastChangeDate: ").Append(LastChangeDate).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  Workplace: ").Append(Workplace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
