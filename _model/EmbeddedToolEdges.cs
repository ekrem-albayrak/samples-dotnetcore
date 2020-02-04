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
    public class EmbeddedToolEdges
    {
        /// <summary>
        /// The tool edges
        /// </summary>
        /// <value>The tool edges</value>
        [DataMember(Name = "toolEdges", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toolEdges")]
        public List<ToolEdge> ToolEdges { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedToolEdges {\n");
            sb.Append("  ToolEdges: ").Append(ToolEdges).Append("\n");
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
