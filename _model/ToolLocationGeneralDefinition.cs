using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ToolLocationGeneralDefinition
    {
        /// <summary>
        /// The workplace
        /// </summary>
        /// <value>The workplace</value>
        [DataMember(Name = "workplaceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaceId")]
        public string WorkplaceId { get; set; }

        /// <summary>
        /// The location of the tool
        /// </summary>
        /// <value>The location of the tool</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// The magazine number of the tool
        /// </summary>
        /// <value>The magazine number of the tool</value>
        [DataMember(Name = "magazineNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "magazineNumber")]
        public int? MagazineNumber { get; set; }

        /// <summary>
        /// The magazine place of the tool
        /// </summary>
        /// <value>The magazine place of the tool</value>
        [DataMember(Name = "magazinePlace", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "magazinePlace")]
        public int? MagazinePlace { get; set; }

        /// <summary>
        /// Removal Mark
        /// </summary>
        /// <value>Removal Mark</value>
        [DataMember(Name = "isMarkedForRemoval", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isMarkedForRemoval")]
        public bool? IsMarkedForRemoval { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToolLocationGeneralDefinition {\n");
            sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MagazineNumber: ").Append(MagazineNumber).Append("\n");
            sb.Append("  MagazinePlace: ").Append(MagazinePlace).Append("\n");
            sb.Append("  IsMarkedForRemoval: ").Append(IsMarkedForRemoval).Append("\n");
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
