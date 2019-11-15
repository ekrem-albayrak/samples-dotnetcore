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
  public class EmbeddedStaffMemberShifts {
    /// <summary>
    /// The staff member shifts
    /// </summary>
    /// <value>The staff member shifts</value>
    [DataMember(Name="shifts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shifts")]
    public List<StaffMemberShift> Shifts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbeddedStaffMemberShifts {\n");
      sb.Append("  Shifts: ").Append(Shifts).Append("\n");
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
