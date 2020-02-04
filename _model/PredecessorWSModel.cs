using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PredecessorWSModel
    {
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name = "operationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or Sets TargetQueueTime
        /// </summary>
        [DataMember(Name = "targetQueueTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targetQueueTime")]
        public long? TargetQueueTime { get; set; }

        /// <summary>
        /// Gets or Sets MinimumSendAheadQuantity
        /// </summary>
        [DataMember(Name = "minimumSendAheadQuantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimumSendAheadQuantity")]
        public double? MinimumSendAheadQuantity { get; set; }

        /// <summary>
        /// Gets or Sets MinimumOffsetTime
        /// </summary>
        [DataMember(Name = "minimumOffsetTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimumOffsetTime")]
        public long? MinimumOffsetTime { get; set; }

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
            sb.Append("class PredecessorWSModel {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  TargetQueueTime: ").Append(TargetQueueTime).Append("\n");
            sb.Append("  MinimumSendAheadQuantity: ").Append(MinimumSendAheadQuantity).Append("\n");
            sb.Append("  MinimumOffsetTime: ").Append(MinimumOffsetTime).Append("\n");
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
