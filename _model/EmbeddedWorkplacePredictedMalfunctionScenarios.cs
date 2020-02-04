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
    public class EmbeddedWorkplacePredictedMalfunctionScenarios
    {
        /// <summary>
        /// The workplace predicted malfunction scenarios.
        /// </summary>
        /// <value>The workplace predicted malfunction scenarios.</value>
        [DataMember(Name = "predictedMalfunctionScenarios", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "predictedMalfunctionScenarios")]
        public List<EmbeddedPredictedMalfunctionScenario> PredictedMalfunctionScenarios { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedWorkplacePredictedMalfunctionScenarios {\n");
            sb.Append("  PredictedMalfunctionScenarios: ").Append(PredictedMalfunctionScenarios).Append("\n");
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
