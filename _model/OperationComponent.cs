using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OperationComponent
    {
        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public Material Material { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets QuantityUnit
        /// </summary>
        [DataMember(Name = "quantityUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantityUnit")]
        public string QuantityUnit { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationComponent {\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
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
