using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class WorkplaceQuantitySummaryDetailProperties
    {
        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name = "material", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "material")]
        public Material Material { get; set; }

        /// <summary>
        /// Gets or Sets QuantityUnit
        /// </summary>
        [DataMember(Name = "quantityUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantityUnit")]
        public string QuantityUnit { get; set; }

        /// <summary>
        /// Gets or Sets TargetTimePerUnit
        /// </summary>
        [DataMember(Name = "targetTimePerUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetTimePerUnit")]
        public long? TargetTimePerUnit { get; set; }

        /// <summary>
        /// Gets or Sets TimePerUnit
        /// </summary>
        [DataMember(Name = "timePerUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePerUnit")]
        public double? TimePerUnit { get; set; }

        /// <summary>
        /// Gets or Sets ProductionTime
        /// </summary>
        [DataMember(Name = "productionTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionTime")]
        public long? ProductionTime { get; set; }

        /// <summary>
        /// Gets or Sets TimePeriod
        /// </summary>
        [DataMember(Name = "timePeriod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePeriod")]
        public TimePeriodDefinition TimePeriod { get; set; }

        /// <summary>
        /// Gets or Sets Quantities
        /// </summary>
        [DataMember(Name = "quantities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantities")]
        public Quantities Quantities { get; set; }

        /// <summary>
        /// Gets or Sets UnconfirmedQuantities
        /// </summary>
        [DataMember(Name = "unconfirmedQuantities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unconfirmedQuantities")]
        public Quantities UnconfirmedQuantities { get; set; }

        /// <summary>
        /// Gets or Sets TotalQuantity
        /// </summary>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalQuantity")]
        public double? TotalQuantity { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkplaceQuantitySummaryDetailProperties {\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
            sb.Append("  TargetTimePerUnit: ").Append(TargetTimePerUnit).Append("\n");
            sb.Append("  TimePerUnit: ").Append(TimePerUnit).Append("\n");
            sb.Append("  ProductionTime: ").Append(ProductionTime).Append("\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  Quantities: ").Append(Quantities).Append("\n");
            sb.Append("  UnconfirmedQuantities: ").Append(UnconfirmedQuantities).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
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
