using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class UpdateOperationPredictedValuesRequestBody
    {
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name = "operationId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or Sets PredictedValues
        /// </summary>
        [DataMember(Name = "predictedValues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "predictedValues")]
        public OperationPredictedValuesProperties PredictedValues { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOperationPredictedValuesRequestBody {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  PredictedValues: ").Append(PredictedValues).Append("\n");
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
