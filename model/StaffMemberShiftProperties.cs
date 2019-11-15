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
  public class StaffMemberShiftProperties {
    /// <summary>
    /// The Id in FORCE to identify a staff member shift
    /// </summary>
    /// <value>The Id in FORCE to identify a staff member shift</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets StaffMemberId
    /// </summary>
    [DataMember(Name="staffMemberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staffMemberId")]
    public string StaffMemberId { get; set; }

    /// <summary>
    /// Gets or Sets Shift
    /// </summary>
    [DataMember(Name="shift", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shift")]
    public Shift Shift { get; set; }

    /// <summary>
    /// Shift type unique id
    /// </summary>
    /// <value>Shift type unique id</value>
    [DataMember(Name="shiftTypeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shiftTypeId")]
    public string ShiftTypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StaffMemberShiftProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  StaffMemberId: ").Append(StaffMemberId).Append("\n");
      sb.Append("  Shift: ").Append(Shift).Append("\n");
      sb.Append("  ShiftTypeId: ").Append(ShiftTypeId).Append("\n");
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
