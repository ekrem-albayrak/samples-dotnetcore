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
    public class EmbeddedToolOrders
    {
        /// <summary>
        /// The tool orders
        /// </summary>
        /// <value>The tool orders</value>
        [DataMember(Name = "toolOrders", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toolOrders")]
        public List<ToolAssemblyOrder> ToolOrders { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedToolOrders {\n");
            sb.Append("  ToolOrders: ").Append(ToolOrders).Append("\n");
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
