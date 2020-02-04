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
    public class EmbeddedWorkplaces
    {
        /// <summary>
        /// The workplaces
        /// </summary>
        /// <value>The workplaces</value>
        [DataMember(Name = "workplaces", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "workplaces")]
        public List<Workplace> Workplaces { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedWorkplaces {\n");
            sb.Append("  Workplaces: ").Append(Workplaces).Append("\n");
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
