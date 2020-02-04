using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ErpContextProperties
    {
        /// <summary>
        /// UUID of the erpContext
        /// </summary>
        /// <value>UUID of the erpContext</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The ERP system
        /// </summary>
        /// <value>The ERP system</value>
        [DataMember(Name = "systemNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "systemNumber")]
        public string SystemNumber { get; set; }

        /// <summary>
        /// The ERP context type
        /// </summary>
        /// <value>The ERP context type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The first identifier of ERP key
        /// </summary>
        /// <value>The first identifier of ERP key</value>
        [DataMember(Name = "identifier1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier1")]
        public string Identifier1 { get; set; }

        /// <summary>
        /// The second identifier of ERP key
        /// </summary>
        /// <value>The second identifier of ERP key</value>
        [DataMember(Name = "identifier2", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier2")]
        public string Identifier2 { get; set; }

        /// <summary>
        /// The third identifier of ERP key
        /// </summary>
        /// <value>The third identifier of ERP key</value>
        [DataMember(Name = "identifier3", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier3")]
        public string Identifier3 { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErpContextProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SystemNumber: ").Append(SystemNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier1: ").Append(Identifier1).Append("\n");
            sb.Append("  Identifier2: ").Append(Identifier2).Append("\n");
            sb.Append("  Identifier3: ").Append(Identifier3).Append("\n");
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
