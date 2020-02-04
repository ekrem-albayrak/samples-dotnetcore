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
    public class EmbeddedQualityTypes
    {
        /// <summary>
        /// The operation quantity types
        /// </summary>
        /// <value>The operation quantity types</value>
        [DataMember(Name = "operationQuantityTypes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationQuantityTypes")]
        public List<QualityType> OperationQuantityTypes { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedQualityTypes {\n");
            sb.Append("  OperationQuantityTypes: ").Append(OperationQuantityTypes).Append("\n");
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
