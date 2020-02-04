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
    public class EmbeddedProductionResourcesAndTools
    {
        /// <summary>
        /// The production resources and tools
        /// </summary>
        /// <value>The production resources and tools</value>
        [DataMember(Name = "productionResourcesAndTools", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionResourcesAndTools")]
        public List<ProductionResourceTool> ProductionResourcesAndTools { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedProductionResourcesAndTools {\n");
            sb.Append("  ProductionResourcesAndTools: ").Append(ProductionResourcesAndTools).Append("\n");
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
