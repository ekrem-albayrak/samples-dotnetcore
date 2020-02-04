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
    public class EmbeddedStatusDefinition
    {
        /// <summary>
        /// The status definitions
        /// </summary>
        /// <value>The status definitions</value>
        [DataMember(Name = "statusDefinitions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusDefinitions")]
        public List<StatusDefinition> StatusDefinitions { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedStatusDefinition {\n");
            sb.Append("  StatusDefinitions: ").Append(StatusDefinitions).Append("\n");
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
