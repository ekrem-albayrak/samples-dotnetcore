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
    public class WorkplaceRequiredSkillWSModel
    {
        /// <summary>
        /// Gets or Sets SkillId
        /// </summary>
        [DataMember(Name = "skillId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "skillId")]
        public string SkillId { get; set; }

        /// <summary>
        /// Gets or Sets MinimumSkill
        /// </summary>
        [DataMember(Name = "minimumSkill", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minimumSkill")]
        public double? MinimumSkill { get; set; }

        /// <summary>
        /// Gets or Sets WorkplaceShiftId
        /// </summary>
        [DataMember(Name = "workplaceShiftId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaceShiftId")]
        public string WorkplaceShiftId { get; set; }

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
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "capacity")]
        public double? Capacity { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkplaceRequiredSkillWSModel {\n");
            sb.Append("  SkillId: ").Append(SkillId).Append("\n");
            sb.Append("  MinimumSkill: ").Append(MinimumSkill).Append("\n");
            sb.Append("  WorkplaceShiftId: ").Append(WorkplaceShiftId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
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
