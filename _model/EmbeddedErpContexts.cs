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
  public class EmbeddedErpContexts {
    /// <summary>
    /// The erp contexts
    /// </summary>
    /// <value>The erp contexts</value>
    [DataMember(Name="erpContexts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "erpContexts")]
    public List<ErpContext> ErpContexts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbeddedErpContexts {\n");
      sb.Append("  ErpContexts: ").Append(ErpContexts).Append("\n");
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
