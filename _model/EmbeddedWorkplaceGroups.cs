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
    public class EmbeddedWorkplaceGroups
    {
        /// <summary>
        /// The workplace groups
        /// </summary>
        /// <value>The workplace groups</value>
        [DataMember(Name = "workplaceGroups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaceGroups")]
        public List<WorkplaceGroup> WorkplaceGroups { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedWorkplaceGroups {\n");
            sb.Append("  WorkplaceGroups: ").Append(WorkplaceGroups).Append("\n");
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
