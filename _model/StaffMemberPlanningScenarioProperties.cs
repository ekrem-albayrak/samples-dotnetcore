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
    public class StaffMemberPlanningScenarioProperties
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime? CreationDate { get; set; }

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
        /// Gets or Sets OperationsPlanningScenarioId
        /// </summary>
        [DataMember(Name = "operationsPlanningScenarioId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationsPlanningScenarioId")]
        public string OperationsPlanningScenarioId { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPlannedStaffMembers
        /// </summary>
        [DataMember(Name = "numberOfPlannedStaffMembers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfPlannedStaffMembers")]
        public long? NumberOfPlannedStaffMembers { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledWorkingTime
        /// </summary>
        [DataMember(Name = "scheduledWorkingTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scheduledWorkingTime")]
        public long? ScheduledWorkingTime { get; set; }

        /// <summary>
        /// Gets or Sets OccupancyTime
        /// </summary>
        [DataMember(Name = "occupancyTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "occupancyTime")]
        public long? OccupancyTime { get; set; }

        /// <summary>
        /// Gets or Sets OccupancyRate
        /// </summary>
        [DataMember(Name = "occupancyRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "occupancyRate")]
        public double? OccupancyRate { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfWorkplaces
        /// </summary>
        [DataMember(Name = "numberOfWorkplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "numberOfWorkplaces")]
        public long? NumberOfWorkplaces { get; set; }

        /// <summary>
        /// Gets or Sets RequirementOfStaffHours
        /// </summary>
        [DataMember(Name = "requirementOfStaffHours", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "requirementOfStaffHours")]
        public long? RequirementOfStaffHours { get; set; }

        /// <summary>
        /// Gets or Sets CoverageOfPersonnelRequirements
        /// </summary>
        [DataMember(Name = "coverageOfPersonnelRequirements", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "coverageOfPersonnelRequirements")]
        public double? CoverageOfPersonnelRequirements { get; set; }

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
            sb.Append("class StaffMemberPlanningScenarioProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  OperationsPlanningScenarioId: ").Append(OperationsPlanningScenarioId).Append("\n");
            sb.Append("  NumberOfPlannedStaffMembers: ").Append(NumberOfPlannedStaffMembers).Append("\n");
            sb.Append("  ScheduledWorkingTime: ").Append(ScheduledWorkingTime).Append("\n");
            sb.Append("  OccupancyTime: ").Append(OccupancyTime).Append("\n");
            sb.Append("  OccupancyRate: ").Append(OccupancyRate).Append("\n");
            sb.Append("  NumberOfWorkplaces: ").Append(NumberOfWorkplaces).Append("\n");
            sb.Append("  RequirementOfStaffHours: ").Append(RequirementOfStaffHours).Append("\n");
            sb.Append("  CoverageOfPersonnelRequirements: ").Append(CoverageOfPersonnelRequirements).Append("\n");
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
