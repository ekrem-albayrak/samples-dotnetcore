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
    public class OperatingStateSummaryPropertiesWSModel
    {
        /// <summary>
        /// Sum of setup and production time of an operation.
        /// </summary>
        /// <value>Sum of setup and production time of an operation.</value>
        [DataMember(Name = "executionTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "executionTime")]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// Processing time of an operation.
        /// </summary>
        /// <value>Processing time of an operation.</value>
        [DataMember(Name = "processingTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "processingTime")]
        public long? ProcessingTime { get; set; }

        /// <summary>
        /// Production time of an operation.
        /// </summary>
        /// <value>Production time of an operation.</value>
        [DataMember(Name = "productionTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionTime")]
        public long? ProductionTime { get; set; }

        /// <summary>
        /// Setup time of an operation.
        /// </summary>
        /// <value>Setup time of an operation.</value>
        [DataMember(Name = "setupTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "setupTime")]
        public long? SetupTime { get; set; }

        /// <summary>
        /// Setup reduction of an operation.
        /// </summary>
        /// <value>Setup reduction of an operation.</value>
        [DataMember(Name = "setupReduction", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "setupReduction")]
        public double? SetupReduction { get; set; }

        /// <summary>
        /// Process availability of an operation.
        /// </summary>
        /// <value>Process availability of an operation.</value>
        [DataMember(Name = "processAvailability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "processAvailability")]
        public double? ProcessAvailability { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "elements")]
        public List<RecordedOperatingStateSummary> Elements { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatingStateSummaryPropertiesWSModel {\n");
            sb.Append("  ExecutionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  ProcessingTime: ").Append(ProcessingTime).Append("\n");
            sb.Append("  ProductionTime: ").Append(ProductionTime).Append("\n");
            sb.Append("  SetupTime: ").Append(SetupTime).Append("\n");
            sb.Append("  SetupReduction: ").Append(SetupReduction).Append("\n");
            sb.Append("  ProcessAvailability: ").Append(ProcessAvailability).Append("\n");
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
