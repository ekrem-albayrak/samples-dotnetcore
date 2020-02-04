using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OperatingStateProperties
    {
        /// <summary>
        /// The Id in FORCE to identify a status definition
        /// </summary>
        /// <value>The Id in FORCE to identify a status definition</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The status definition description
        /// </summary>
        /// <value>The status definition description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The numeric code of the status definition
        /// </summary>
        /// <value>The numeric code of the status definition</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The color which is used to display the status definition
        /// </summary>
        /// <value>The color which is used to display the status definition</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets WorkplaceStateId
        /// </summary>
        [DataMember(Name = "workplaceStateId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaceStateId")]
        public string WorkplaceStateId { get; set; }

        /// <summary>
        /// Gets or Sets OperatingStateClassId
        /// </summary>
        [DataMember(Name = "operatingStateClassId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operatingStateClassId")]
        public string OperatingStateClassId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatingStateProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  WorkplaceStateId: ").Append(WorkplaceStateId).Append("\n");
            sb.Append("  OperatingStateClassId: ").Append(OperatingStateClassId).Append("\n");
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
