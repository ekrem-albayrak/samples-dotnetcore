using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class QualityDetailProperties
    {
        /// <summary>
        /// The Id in FORCE to identify a quality detail
        /// </summary>
        /// <value>The Id in FORCE to identify a quality detail</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The description of the quality detail
        /// </summary>
        /// <value>The description of the quality detail</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The short description of the quality detail
        /// </summary>
        /// <value>The short description of the quality detail</value>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The quality type id of the quality detail
        /// </summary>
        /// <value>The quality type id of the quality detail</value>
        [DataMember(Name = "qualityTypeId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "qualityTypeId")]
        public string QualityTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The color as RGB (e.g. ffffff) of the quality detail
        /// </summary>
        /// <value>The color as RGB (e.g. ffffff) of the quality detail</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityDetailProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  QualityTypeId: ").Append(QualityTypeId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
