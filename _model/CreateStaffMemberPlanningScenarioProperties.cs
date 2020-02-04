using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateStaffMemberPlanningScenarioProperties
    {
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets OperationsPlanningScenarioId
        /// </summary>
        [DataMember(Name = "operationsPlanningScenarioId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationsPlanningScenarioId")]
        public string OperationsPlanningScenarioId { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "elements")]
        public List<StaffMemberAssignment> Elements { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStaffMemberPlanningScenarioProperties {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  OperationsPlanningScenarioId: ").Append(OperationsPlanningScenarioId).Append("\n");
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
