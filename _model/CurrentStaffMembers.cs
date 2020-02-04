using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FORCAM.BridgeAPI.Model
{

    public class CurrentStaffMember
    {
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "properties")]
        public StaffMemberProperties Properties { get; set; }
    }

    public class Embedded
    {
        [DataMember(Name = "currentStaffMembers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currentStaffMembers")]
        public List<CurrentStaffMember> CurrentStaffMembers { get; set; }
    }

    public class CurrentStaffMemberEmbed
    {
        [DataMember(Name = "_embedded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "_embedded")]
        public Embedded Embedded { get; set; }
    }
}
