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
  public class SearchOperations {
    /// <summary>
    /// Gets or Sets Dispatched
    /// </summary>
    [DataMember(Name="dispatched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dispatched")]
    public bool? Dispatched { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets ErpContextIds
    /// </summary>
    [DataMember(Name="erpContextIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "erpContextIds")]
    public List<string> ErpContextIds { get; set; }

    /// <summary>
    /// Gets or Sets InProgress
    /// </summary>
    [DataMember(Name="inProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inProgress")]
    public bool? InProgress { get; set; }

    /// <summary>
    /// Gets or Sets IsDispatched
    /// </summary>
    [DataMember(Name="isDispatched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDispatched")]
    public bool? IsDispatched { get; set; }

    /// <summary>
    /// Gets or Sets IsInProgress
    /// </summary>
    [DataMember(Name="isInProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isInProgress")]
    public bool? IsInProgress { get; set; }

    /// <summary>
    /// Gets or Sets IsPlannable
    /// </summary>
    [DataMember(Name="isPlannable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPlannable")]
    public bool? IsPlannable { get; set; }

    /// <summary>
    /// Gets or Sets MaterialNumbers
    /// </summary>
    [DataMember(Name="materialNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "materialNumbers")]
    public List<string> MaterialNumbers { get; set; }

    /// <summary>
    /// Gets or Sets OperationIds
    /// </summary>
    [DataMember(Name="operationIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationIds")]
    public List<string> OperationIds { get; set; }

    /// <summary>
    /// Gets or Sets OperationNumbers
    /// </summary>
    [DataMember(Name="operationNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationNumbers")]
    public List<string> OperationNumbers { get; set; }

    /// <summary>
    /// Gets or Sets OperationSplits
    /// </summary>
    [DataMember(Name="operationSplits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationSplits")]
    public List<string> OperationSplits { get; set; }

    /// <summary>
    /// Gets or Sets PhaseIds
    /// </summary>
    [DataMember(Name="phaseIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phaseIds")]
    public List<string> PhaseIds { get; set; }

    /// <summary>
    /// Gets or Sets Plannable
    /// </summary>
    [DataMember(Name="plannable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannable")]
    public bool? Plannable { get; set; }

    /// <summary>
    /// Gets or Sets PlannedWorkplaceIds
    /// </summary>
    [DataMember(Name="plannedWorkplaceIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedWorkplaceIds")]
    public List<string> PlannedWorkplaceIds { get; set; }

    /// <summary>
    /// Gets or Sets PlannedWorkplaceNumbers
    /// </summary>
    [DataMember(Name="plannedWorkplaceNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedWorkplaceNumbers")]
    public List<string> PlannedWorkplaceNumbers { get; set; }

    /// <summary>
    /// Gets or Sets ProductionOrderIds
    /// </summary>
    [DataMember(Name="productionOrderIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionOrderIds")]
    public List<string> ProductionOrderIds { get; set; }

    /// <summary>
    /// Gets or Sets ProductionOrderNumbers
    /// </summary>
    [DataMember(Name="productionOrderNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionOrderNumbers")]
    public List<string> ProductionOrderNumbers { get; set; }

    /// <summary>
    /// Gets or Sets ProductionOrderSplits
    /// </summary>
    [DataMember(Name="productionOrderSplits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productionOrderSplits")]
    public List<string> ProductionOrderSplits { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets TargetWorkplaceIds
    /// </summary>
    [DataMember(Name="targetWorkplaceIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWorkplaceIds")]
    public List<string> TargetWorkplaceIds { get; set; }

    /// <summary>
    /// Gets or Sets TargetWorkplaceNumbers
    /// </summary>
    [DataMember(Name="targetWorkplaceNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWorkplaceNumbers")]
    public List<string> TargetWorkplaceNumbers { get; set; }

    /// <summary>
    /// Gets or Sets WorkplaceIds
    /// </summary>
    [DataMember(Name="workplaceIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceIds")]
    public List<string> WorkplaceIds { get; set; }

    /// <summary>
    /// Gets or Sets WorkplaceNumbers
    /// </summary>
    [DataMember(Name="workplaceNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workplaceNumbers")]
    public List<string> WorkplaceNumbers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchOperations {\n");
      sb.Append("  Dispatched: ").Append(Dispatched).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  ErpContextIds: ").Append(ErpContextIds).Append("\n");
      sb.Append("  InProgress: ").Append(InProgress).Append("\n");
      sb.Append("  IsDispatched: ").Append(IsDispatched).Append("\n");
      sb.Append("  IsInProgress: ").Append(IsInProgress).Append("\n");
      sb.Append("  IsPlannable: ").Append(IsPlannable).Append("\n");
      sb.Append("  MaterialNumbers: ").Append(MaterialNumbers).Append("\n");
      sb.Append("  OperationIds: ").Append(OperationIds).Append("\n");
      sb.Append("  OperationNumbers: ").Append(OperationNumbers).Append("\n");
      sb.Append("  OperationSplits: ").Append(OperationSplits).Append("\n");
      sb.Append("  PhaseIds: ").Append(PhaseIds).Append("\n");
      sb.Append("  Plannable: ").Append(Plannable).Append("\n");
      sb.Append("  PlannedWorkplaceIds: ").Append(PlannedWorkplaceIds).Append("\n");
      sb.Append("  PlannedWorkplaceNumbers: ").Append(PlannedWorkplaceNumbers).Append("\n");
      sb.Append("  ProductionOrderIds: ").Append(ProductionOrderIds).Append("\n");
      sb.Append("  ProductionOrderNumbers: ").Append(ProductionOrderNumbers).Append("\n");
      sb.Append("  ProductionOrderSplits: ").Append(ProductionOrderSplits).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  TargetWorkplaceIds: ").Append(TargetWorkplaceIds).Append("\n");
      sb.Append("  TargetWorkplaceNumbers: ").Append(TargetWorkplaceNumbers).Append("\n");
      sb.Append("  WorkplaceIds: ").Append(WorkplaceIds).Append("\n");
      sb.Append("  WorkplaceNumbers: ").Append(WorkplaceNumbers).Append("\n");
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
