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
    public class ProductionOrderSpecification
    {
        /// <summary>
        /// HAL embedded objects
        /// </summary>
        /// <value>HAL embedded objects</value>
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_embedded")]
        public Object Embedded { get; set; }

        /// <summary>
        /// HAL link objects
        /// </summary>
        /// <value>HAL link objects</value>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_links")]
        public Object Links { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "properties")]
        public ProductionOrderSpecification Properties { get; set; }

        /// <summary>
        /// The target yield quantity
        /// </summary>
        /// <value>The target yield quantity</value>
        [DataMember(Name = "targetQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetQuantity")]
        public double? TargetQuantity { get; set; }

        /// <summary>
        /// The unit of the target quantity target yield quantity
        /// </summary>
        /// <value>The unit of the target quantity target yield quantity</value>
        [DataMember(Name = "quantityUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantityUnit")]
        public string QuantityUnit { get; set; }

        /// <summary>
        /// Earliest start date of the production order
        /// </summary>
        /// <value>Earliest start date of the production order</value>
        [DataMember(Name = "basicStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "basicStartDate")]
        public DateTime? BasicStartDate { get; set; }

        /// <summary>
        /// Latest end date of the production order
        /// </summary>
        /// <value>Latest end date of the production order</value>
        [DataMember(Name = "basicEndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "basicEndDate")]
        public DateTime? BasicEndDate { get; set; }

        /// <summary>
        /// An arbitrary integer value for the priority of a production order specified in the ERP system. The highest priority is 0.
        /// </summary>
        /// <value>An arbitrary integer value for the priority of a production order specified in the ERP system. The highest priority is 0.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        /// <summary>
        /// The degree of parallelization used, among other things, to determine the throughput efficiency
        /// </summary>
        /// <value>The degree of parallelization used, among other things, to determine the throughput efficiency</value>
        [DataMember(Name = "degreeOfParallelization", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "degreeOfParallelization")]
        public double? DegreeOfParallelization { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductionOrderSpecification {\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  TargetQuantity: ").Append(TargetQuantity).Append("\n");
            sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
            sb.Append("  BasicStartDate: ").Append(BasicStartDate).Append("\n");
            sb.Append("  BasicEndDate: ").Append(BasicEndDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DegreeOfParallelization: ").Append(DegreeOfParallelization).Append("\n");
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
