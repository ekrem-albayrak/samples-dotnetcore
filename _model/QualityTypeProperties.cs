using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class QualityTypeProperties
    {
        /// <summary>
        /// The Id in FORCE to identify an quality type
        /// </summary>
        /// <value>The Id in FORCE to identify an quality type</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Description of the quantity type
        /// </summary>
        /// <value>Description of the quantity type</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Short description of the quantity type
        /// </summary>
        /// <value>Short description of the quantity type</value>
        [DataMember(Name = "shortDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Color as RGB (e.g. ffffff) of the quantity type
        /// </summary>
        /// <value>Color as RGB (e.g. ffffff) of the quantity type</value>
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
            sb.Append("class QualityTypeProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
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
