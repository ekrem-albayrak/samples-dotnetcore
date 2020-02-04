using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace logic
{
    public class Token
    {
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "access_token")]
        public string Access_token { get; set; }

        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "token_type")]
        public string Token_type { get; set; }

        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expires_in")]
        public int Expires_in { get; set; }

        [DataMember(Name = "scope", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
    }
}
