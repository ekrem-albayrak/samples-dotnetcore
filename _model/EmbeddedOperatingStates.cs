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
    public class EmbeddedOperatingStates
    {
        /// <summary>
        /// The operating states
        /// </summary>
        /// <value>The operating states</value>
        [DataMember(Name = "operatingStates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operatingStates")]
        public List<OperatingState> OperatingStates { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedOperatingStates {\n");
            sb.Append("  StatusDefinitions: ").Append(OperatingStates).Append("\n");
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
