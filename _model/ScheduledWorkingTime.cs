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
    public class ScheduledWorkingTime
    {
        /// <summary>
        /// Gets or Sets StaffMemberId
        /// </summary>
        [DataMember(Name = "staffMemberId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "staffMemberId")]
        public string StaffMemberId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledWorkingTimes
        /// </summary>
        [DataMember(Name = "scheduledWorkingTimes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledWorkingTimes")]
        public List<TimePeriodDefinition> ScheduledWorkingTimes { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledWorkingTime {\n");
            sb.Append("  StaffMemberId: ").Append(StaffMemberId).Append("\n");
            sb.Append("  ScheduledWorkingTimes: ").Append(ScheduledWorkingTimes).Append("\n");
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
