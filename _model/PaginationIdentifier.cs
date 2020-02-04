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
    public class PaginationIdentifier
    {
        /// <summary>
        /// Identifier which makes the pagination entry unique.
        /// </summary>
        /// <value>Identifier which makes the pagination entry unique.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The pagination timestamp.
        /// </summary>
        /// <value>The pagination timestamp.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginationIdentifier {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
