using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FORCAM.BridgeAPI.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Translation {
    /// <summary>
    /// The language tag containing the language code (ISO 639) and the country code (ISO 3166).
    /// </summary>
    /// <value>The language tag containing the language code (ISO 639) and the country code (ISO 3166).</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The term translated into the corresponding language
    /// </summary>
    /// <value>The term translated into the corresponding language</value>
    [DataMember(Name="translation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translation")]
    public string _Translation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Translation {\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  _Translation: ").Append(_Translation).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
