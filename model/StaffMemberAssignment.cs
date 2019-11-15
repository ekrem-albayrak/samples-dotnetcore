using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FORCAM.BridgeAPI.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class StaffMemberAssignment {
    /// <summary>
    /// Staff member ID
    /// </summary>
    /// <value>Staff member ID</value>
    [DataMember(Name="staffMemberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staffMemberId")]
    public string StaffMemberId { get; set; }

    /// <summary>
    /// Staff member shift ID
    /// </summary>
    /// <value>Staff member shift ID</value>
    [DataMember(Name="staffMemberShiftId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staffMemberShiftId")]
    public string StaffMemberShiftId { get; set; }

    /// <summary>
    /// Workplace ID
    /// </summary>
    /// <value>Workplace ID</value>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// Skill ID
    /// </summary>
    /// <value>Skill ID</value>
    [DataMember(Name="skillId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skillId")]
    public string SkillId { get; set; }

    /// <summary>
    /// Workplace shift ID
    /// </summary>
    /// <value>Workplace shift ID</value>
    [DataMember(Name="workplaceShiftId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceShiftId")]
    public string WorkplaceShiftId { get; set; }

    /// <summary>
    /// Start date
    /// </summary>
    /// <value>Start date</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date
    /// </summary>
    /// <value>End date</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Capacity
    /// </summary>
    /// <value>Capacity</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacity")]
    public double? Capacity { get; set; }

    /// <summary>
    /// Flag if assignment is fixed
    /// </summary>
    /// <value>Flag if assignment is fixed</value>
    [DataMember(Name="fixed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed")]
    public bool? _Fixed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StaffMemberAssignment {\n");
      sb.Append("  StaffMemberId: ").Append(StaffMemberId).Append("\n");
      sb.Append("  StaffMemberShiftId: ").Append(StaffMemberShiftId).Append("\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  SkillId: ").Append(SkillId).Append("\n");
      sb.Append("  WorkplaceShiftId: ").Append(WorkplaceShiftId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      sb.Append("  _Fixed: ").Append(_Fixed).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
