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
    public class EmbeddedWorkplaceShifts
    {
        /// <summary>
        /// The shifts
        /// </summary>
        /// <value>The shifts</value>
        [DataMember(Name = "shifts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shifts")]
        public List<WorkplaceShift> Shifts { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedWorkplaceShifts {\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
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
