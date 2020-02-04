using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OperationSpecificationProperties
    {
        /// <summary>
        /// Gets or Sets TargetCapacityGroup
        /// </summary>
        [DataMember(Name = "targetCapacityGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetCapacityGroup")]
        public WorkplaceGroupProperties TargetCapacityGroup { get; set; }

        /// <summary>
        /// Gets or Sets TargetWorkplace
        /// </summary>
        [DataMember(Name = "targetWorkplace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetWorkplace")]
        public WorkplaceGeneralDefinition TargetWorkplace { get; set; }

        /// <summary>
        /// Gets or Sets TargetQuantity
        /// </summary>
        [DataMember(Name = "targetQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetQuantity")]
        public double? TargetQuantity { get; set; }

        /// <summary>
        /// Target scrap quantity time in ms
        /// </summary>
        /// <value>Target scrap quantity time in ms</value>
        [DataMember(Name = "plannedScrapQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plannedScrapQuantity")]
        public double? PlannedScrapQuantity { get; set; }

        /// <summary>
        /// Gets or Sets QuantityUnit
        /// </summary>
        [DataMember(Name = "quantityUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantityUnit")]
        public string QuantityUnit { get; set; }

        /// <summary>
        /// Target time per unit in ms
        /// </summary>
        /// <value>Target time per unit in ms</value>
        [DataMember(Name = "targetTimePerUnit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetTimePerUnit")]
        public long? TargetTimePerUnit { get; set; }

        /// <summary>
        /// Gets or Sets TargetMachineCycleTime
        /// </summary>
        [DataMember(Name = "targetMachineCycleTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetMachineCycleTime")]
        public long? TargetMachineCycleTime { get; set; }

        /// <summary>
        /// Gets or Sets UnitsPerMachineCycle
        /// </summary>
        [DataMember(Name = "unitsPerMachineCycle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unitsPerMachineCycle")]
        public double? UnitsPerMachineCycle { get; set; }

        /// <summary>
        /// Gets or Sets TargetQueueTime
        /// </summary>
        [DataMember(Name = "targetQueueTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetQueueTime")]
        public long? TargetQueueTime { get; set; }

        /// <summary>
        /// Target setup time in ms
        /// </summary>
        /// <value>Target setup time in ms</value>
        [DataMember(Name = "targetSetupTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetSetupTime")]
        public long? TargetSetupTime { get; set; }

        /// <summary>
        /// Target processing time in ms
        /// </summary>
        /// <value>Target processing time in ms</value>
        [DataMember(Name = "targetProcessingTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetProcessingTime")]
        public long? TargetProcessingTime { get; set; }

        /// <summary>
        /// Target teardown time in ms
        /// </summary>
        /// <value>Target teardown time in ms</value>
        [DataMember(Name = "targetTeardownTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetTeardownTime")]
        public long? TargetTeardownTime { get; set; }

        /// <summary>
        /// Target wait time in ms
        /// </summary>
        /// <value>Target wait time in ms</value>
        [DataMember(Name = "targetWaitTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetWaitTime")]
        public long? TargetWaitTime { get; set; }

        /// <summary>
        /// Target move time in ms
        /// </summary>
        /// <value>Target move time in ms</value>
        [DataMember(Name = "targetMoveTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetMoveTime")]
        public long? TargetMoveTime { get; set; }

        /// <summary>
        /// Gets or Sets MinimumSendAheadQuantity
        /// </summary>
        [DataMember(Name = "minimumSendAheadQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimumSendAheadQuantity")]
        public double? MinimumSendAheadQuantity { get; set; }

        /// <summary>
        /// Gets or Sets MinimumOverlapTime
        /// </summary>
        [DataMember(Name = "minimumOverlapTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimumOverlapTime")]
        public long? MinimumOverlapTime { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationSpecificationProperties {\n");
            sb.Append("  TargetCapacityGroup: ").Append(TargetCapacityGroup).Append("\n");
            sb.Append("  TargetWorkplace: ").Append(TargetWorkplace).Append("\n");
            sb.Append("  TargetQuantity: ").Append(TargetQuantity).Append("\n");
            sb.Append("  PlannedScrapQuantity: ").Append(PlannedScrapQuantity).Append("\n");
            sb.Append("  QuantityUnit: ").Append(QuantityUnit).Append("\n");
            sb.Append("  TargetTimePerUnit: ").Append(TargetTimePerUnit).Append("\n");
            sb.Append("  TargetMachineCycleTime: ").Append(TargetMachineCycleTime).Append("\n");
            sb.Append("  UnitsPerMachineCycle: ").Append(UnitsPerMachineCycle).Append("\n");
            sb.Append("  TargetQueueTime: ").Append(TargetQueueTime).Append("\n");
            sb.Append("  TargetSetupTime: ").Append(TargetSetupTime).Append("\n");
            sb.Append("  TargetProcessingTime: ").Append(TargetProcessingTime).Append("\n");
            sb.Append("  TargetTeardownTime: ").Append(TargetTeardownTime).Append("\n");
            sb.Append("  TargetWaitTime: ").Append(TargetWaitTime).Append("\n");
            sb.Append("  TargetMoveTime: ").Append(TargetMoveTime).Append("\n");
            sb.Append("  MinimumSendAheadQuantity: ").Append(MinimumSendAheadQuantity).Append("\n");
            sb.Append("  MinimumOverlapTime: ").Append(MinimumOverlapTime).Append("\n");
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
