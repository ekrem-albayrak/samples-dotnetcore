using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class LifeTime
    {
        /// <summary>
        /// The tool edge life time in ms
        /// </summary>
        /// <value>The tool edge life time in ms</value>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "current")]
        public long? Current { get; set; }

        /// <summary>
        /// The tool edge life time warning threshold in ms
        /// </summary>
        /// <value>The tool edge life time warning threshold in ms</value>
        [DataMember(Name = "warn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "warn")]
        public long? Warn { get; set; }

        /// <summary>
        /// The tool edge maximum life time in ms
        /// </summary>
        /// <value>The tool edge maximum life time in ms</value>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "max")]
        public long? Max { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LifeTime {\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Warn: ").Append(Warn).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
