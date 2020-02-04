using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RecordedOperatingStateSummary
    {
        /// <summary>
        /// Gets or Sets OperatingState
        /// </summary>
        [DataMember(Name = "operatingState", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operatingState")]
        public OperatingStateGeneralDefinition OperatingState { get; set; }

        /// <summary>
        /// Duration of this operating state.
        /// </summary>
        /// <value>Duration of this operating state.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// Frequency of this operating state.
        /// </summary>
        /// <value>Frequency of this operating state.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "frequency")]
        public int? Frequency { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordedOperatingStateSummary {\n");
            sb.Append("  OperatingState: ").Append(OperatingState).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
