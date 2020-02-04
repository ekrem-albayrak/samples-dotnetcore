using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class StaffMemberProperties
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ErpContextId
        /// </summary>
        [DataMember(Name = "erpContextId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erpContextId")]
        public string ErpContextId { get; set; }

        /// <summary>
        /// Gets or Sets IdentificationNumber
        /// </summary>
        [DataMember(Name = "identificationNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identificationNumber")]
        public string IdentificationNumber { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffMemberProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ErpContextId: ").Append(ErpContextId).Append("\n");
            sb.Append("  IdentificationNumber: ").Append(IdentificationNumber).Append("\n");
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
