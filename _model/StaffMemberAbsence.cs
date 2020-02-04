using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class StaffMemberAbsence
    {
        /// <summary>
        /// Gets or Sets TimePeriod
        /// </summary>
        [DataMember(Name = "timePeriod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timePeriod")]
        public TimePeriodDefinition TimePeriod { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffMemberAbsence {\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
