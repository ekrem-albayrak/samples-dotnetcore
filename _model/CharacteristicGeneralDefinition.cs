using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CharacteristicGeneralDefinition
    {
        /// <summary>
        /// The name of the characteristic
        /// </summary>
        /// <value>The name of the characteristic</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The identifier of the characteristic (for example used in ISO 13399)
        /// </summary>
        /// <value>The identifier of the characteristic (for example used in ISO 13399)</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The characteristic
        /// </summary>
        /// <value>The characteristic</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// The unit of the characteristic
        /// </summary>
        /// <value>The unit of the characteristic</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CharacteristicGeneralDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
