using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ProductionOrderOperation
    {
        /// <summary>
        /// The Id in FORCE to identify an operation
        /// </summary>
        /// <value>The Id in FORCE to identify an operation</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The operation number (most likely overtaken from ERP)
        /// </summary>
        /// <value>The operation number (most likely overtaken from ERP)</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Split
        /// </summary>
        [DataMember(Name = "split", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "split")]
        public string Split { get; set; }

        /// <summary>
        /// The sequence number
        /// </summary>
        /// <value>The sequence number</value>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sequenceNumber")]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// The operation description
        /// </summary>
        /// <value>The operation description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ProductionOrder
        /// </summary>
        [DataMember(Name = "productionOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionOrder")]
        public ProductionOrderGeneralDefinition ProductionOrder { get; set; }

        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public Material Material { get; set; }

        /// <summary>
        /// The Id in FORCE to identify the erp context of the operation
        /// </summary>
        /// <value>The Id in FORCE to identify the erp context of the operation</value>
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
            sb.Append("class ProductionOrderOperation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Split: ").Append(Split).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductionOrder: ").Append(ProductionOrder).Append("\n");
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
