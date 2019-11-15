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
  public class CollectionProperties {
    /// <summary>
    /// The number of elements currently on this page
    /// </summary>
    /// <value>The number of elements currently on this page</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The identifier of the first element on page
    /// </summary>
    /// <value>The identifier of the first element on page</value>
    [DataMember(Name="firstIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstIdentifier")]
    public PaginationIdentifier FirstIdentifier { get; set; }

    /// <summary>
    /// The identifier of the last element on page
    /// </summary>
    /// <value>The identifier of the last element on page</value>
    [DataMember(Name="lastIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastIdentifier")]
    public PaginationIdentifier LastIdentifier { get; set; }

    /// <summary>
    /// The size of the page
    /// </summary>
    /// <value>The size of the page</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// The offset of the page
    /// </summary>
    /// <value>The offset of the page</value>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// The total amount of elements
    /// </summary>
    /// <value>The total amount of elements</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public long? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CollectionProperties {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  FirstIdentifier: ").Append(FirstIdentifier).Append("\n");
      sb.Append("  LastIdentifier: ").Append(LastIdentifier).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
