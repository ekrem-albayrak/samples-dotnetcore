using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Quantities
    {
        /// <summary>
        /// Gets or Sets Yield
        /// </summary>
        [DataMember(Name = "yield", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yield")]
        public double? Yield { get; set; }

        /// <summary>
        /// Gets or Sets Scrap
        /// </summary>
        [DataMember(Name = "scrap", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scrap")]
        public double? Scrap { get; set; }

        /// <summary>
        /// Gets or Sets Rework
        /// </summary>
        [DataMember(Name = "rework", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rework")]
        public double? Rework { get; set; }

        /// <summary>
        /// Gets or Sets Uncategorized
        /// </summary>
        [DataMember(Name = "uncategorized", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uncategorized")]
        public double? Uncategorized { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quantities {\n");
            sb.Append("  Yield: ").Append(Yield).Append("\n");
            sb.Append("  Scrap: ").Append(Scrap).Append("\n");
            sb.Append("  Rework: ").Append(Rework).Append("\n");
            sb.Append("  Uncategorized: ").Append(Uncategorized).Append("\n");
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
