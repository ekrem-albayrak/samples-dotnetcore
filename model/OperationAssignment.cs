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
  public class OperationAssignment {
    /// <summary>
    /// Operation.
    /// </summary>
    /// <value>Operation.</value>
    [DataMember(Name="operationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationId")]
    public string OperationId { get; set; }

    /// <summary>
    /// UUID of the planned workplace 
    /// </summary>
    /// <value>UUID of the planned workplace </value>
    [DataMember(Name="workplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceId")]
    public string WorkplaceId { get; set; }

    /// <summary>
    /// Planned start date of planning scenario.
    /// </summary>
    /// <value>Planned start date of planning scenario.</value>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Planned end date of a planning scenario.
    /// </summary>
    /// <value>Planned end date of a planning scenario.</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Planned start date of the setup.
    /// </summary>
    /// <value>Planned start date of the setup.</value>
    [DataMember(Name="setupStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupStartDate")]
    public DateTime? SetupStartDate { get; set; }

    /// <summary>
    /// Planned end date of the setup.
    /// </summary>
    /// <value>Planned end date of the setup.</value>
    [DataMember(Name="setupEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupEndDate")]
    public DateTime? SetupEndDate { get; set; }

    /// <summary>
    /// Planned start date of the processing.
    /// </summary>
    /// <value>Planned start date of the processing.</value>
    [DataMember(Name="processingStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingStartDate")]
    public DateTime? ProcessingStartDate { get; set; }

    /// <summary>
    /// Planned end date of the processing.
    /// </summary>
    /// <value>Planned end date of the processing.</value>
    [DataMember(Name="processingEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingEndDate")]
    public DateTime? ProcessingEndDate { get; set; }

    /// <summary>
    /// This flag indicates that an operation must not be rescheduled during automatic order planning.
    /// </summary>
    /// <value>This flag indicates that an operation must not be rescheduled during automatic order planning.</value>
    [DataMember(Name="fixed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed")]
    public bool? _Fixed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationAssignment {\n");
      sb.Append("  OperationId: ").Append(OperationId).Append("\n");
      sb.Append("  WorkplaceId: ").Append(WorkplaceId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  SetupStartDate: ").Append(SetupStartDate).Append("\n");
      sb.Append("  SetupEndDate: ").Append(SetupEndDate).Append("\n");
      sb.Append("  ProcessingStartDate: ").Append(ProcessingStartDate).Append("\n");
      sb.Append("  ProcessingEndDate: ").Append(ProcessingEndDate).Append("\n");
      sb.Append("  _Fixed: ").Append(_Fixed).Append("\n");
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
