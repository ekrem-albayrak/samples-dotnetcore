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
    public class Machine
    {
        /// <summary>
        /// HAL embedded objects
        /// </summary>
        /// <value>HAL embedded objects</value>
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_embedded")]
        public Object Embedded { get; set; }

        /// <summary>
        /// Contains the linked resources: erpKey
        /// </summary>
        /// <value>Contains the linked resources: erpKey</value>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_links")]
        public Object Links { get; set; }

        /// <summary>
        /// The Machine properties
        /// </summary>
        /// <value>The Machine properties</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "properties")]
        public MachineProperties Properties { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Machine {\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
