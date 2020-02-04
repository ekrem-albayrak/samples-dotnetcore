using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateFileRepositoryFolderProperties
    {
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
        /// Gets or Sets WorkplaceId
        /// </summary>
        [DataMember(Name = "workplaceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaceId")]
        public string WorkplaceId { get; set; }

        /// <summary>
        /// Gets or Sets MaterialNumber
        /// </summary>
        [DataMember(Name = "materialNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "materialNumber")]
        public string MaterialNumber { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileRepositoryFolderProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
            sb.Append("  MaterialNumber: ").Append(MaterialNumber).Append("\n");
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
