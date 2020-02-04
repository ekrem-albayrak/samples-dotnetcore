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
    public class EmbeddedOperationPlanningScenarios
    {
        /// <summary>
        /// The operation planning scenarios.
        /// </summary>
        /// <value>The operation planning scenarios.</value>
        [DataMember(Name = "planningScenarios", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "planningScenarios")]
        public List<OperationPlanningScenarioWSModel> PlanningScenarios { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedOperationPlanningScenarios {\n");
            sb.Append("  PlanningScenarios: ").Append(PlanningScenarios).Append("\n");
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
