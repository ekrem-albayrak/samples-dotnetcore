using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class EmbeddedFileRepositoryFolders
    {
        /// <summary>
        /// The folders
        /// </summary>
        /// <value>The folders</value>
        [DataMember(Name = "folders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "folders")]
        public List<FileRepositoryFolder> Folders { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedFileRepositoryFolders {\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
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
