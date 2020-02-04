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
    public class WorkplaceQuantitySummaryCollectionProperties
    {
        /// <summary>
        /// The performance rate of the workplace during the selected time period.
        /// </summary>
        /// <value>The performance rate of the workplace during the selected time period.</value>
        [DataMember(Name = "performance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "performance")]
        public double? Performance { get; set; }

        /// <summary>
        /// The time based quality rate of the work-place during the selected time period.
        /// </summary>
        /// <value>The time based quality rate of the work-place during the selected time period.</value>
        [DataMember(Name = "timeBasedQualityRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeBasedQualityRate")]
        public double? TimeBasedQualityRate { get; set; }

        /// <summary>
        /// The quantity based quality rate of the work-place during the selected time period.
        /// </summary>
        /// <value>The quantity based quality rate of the work-place during the selected time period.</value>
        [DataMember(Name = "quantityBasedQualityRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantityBasedQualityRate")]
        public double? QuantityBasedQualityRate { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "elements")]
        public List<WorkplaceQuantitySummaryDetailProperties> Elements { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkplaceQuantitySummaryCollectionProperties {\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  TimeBasedQualityRate: ").Append(TimeBasedQualityRate).Append("\n");
            sb.Append("  QuantityBasedQualityRate: ").Append(QuantityBasedQualityRate).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
