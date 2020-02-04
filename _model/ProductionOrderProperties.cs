using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ProductionOrderProperties
    {
        /// <summary>
        /// The ID in FORCE to identify a production order
        /// </summary>
        /// <value>The ID in FORCE to identify a production order</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The production order number (most likely overtaken from ERP) the operation belongs to
        /// </summary>
        /// <value>The production order number (most likely overtaken from ERP) the operation belongs to</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The production order split
        /// </summary>
        /// <value>The production order split</value>
        [DataMember(Name = "split", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "split")]
        public string Split { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        /// <value>The description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public Material Material { get; set; }

        /// <summary>
        /// The erp context id
        /// </summary>
        /// <value>The erp context id</value>
        [DataMember(Name = "erpContextId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erpContextId")]
        public string ErpContextId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductionOrderProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Split: ").Append(Split).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  ErpContextId: ").Append(ErpContextId).Append("\n");
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
