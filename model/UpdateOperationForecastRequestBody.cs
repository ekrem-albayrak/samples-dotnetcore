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
  public class UpdateOperationForecastRequestBody {
    /// <summary>
    /// Gets or Sets ForecastResults
    /// </summary>
    [DataMember(Name="forecastResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forecastResults")]
    public List<OperationAssignment> ForecastResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateOperationForecastRequestBody {\n");
      sb.Append("  ForecastResults: ").Append(ForecastResults).Append("\n");
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
