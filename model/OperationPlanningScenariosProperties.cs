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
  public class OperationPlanningScenariosProperties {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public string Creator { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfWorkplaces
    /// </summary>
    [DataMember(Name="numberOfWorkplaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfWorkplaces")]
    public long? NumberOfWorkplaces { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledOperatingTime
    /// </summary>
    [DataMember(Name="scheduledOperatingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledOperatingTime")]
    public long? ScheduledOperatingTime { get; set; }

    /// <summary>
    /// Gets or Sets PlannedProcessingTime
    /// </summary>
    [DataMember(Name="plannedProcessingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedProcessingTime")]
    public long? PlannedProcessingTime { get; set; }

    /// <summary>
    /// Gets or Sets PlannedExecutionTime
    /// </summary>
    [DataMember(Name="plannedExecutionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedExecutionTime")]
    public long? PlannedExecutionTime { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfPlannedProductionOrders
    /// </summary>
    [DataMember(Name="numberOfPlannedProductionOrders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPlannedProductionOrders")]
    public long? NumberOfPlannedProductionOrders { get; set; }

    /// <summary>
    /// Gets or Sets PlannedLeadTime
    /// </summary>
    [DataMember(Name="plannedLeadTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedLeadTime")]
    public long? PlannedLeadTime { get; set; }

    /// <summary>
    /// Gets or Sets MinimumLeadTimeWithSetup
    /// </summary>
    [DataMember(Name="minimumLeadTimeWithSetup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumLeadTimeWithSetup")]
    public long? MinimumLeadTimeWithSetup { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfPartiallyPlannedProductionOrders
    /// </summary>
    [DataMember(Name="numberOfPartiallyPlannedProductionOrders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPartiallyPlannedProductionOrders")]
    public long? NumberOfPartiallyPlannedProductionOrders { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceToDeliveryDates
    /// </summary>
    [DataMember(Name="adherenceToDeliveryDates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adherenceToDeliveryDates")]
    public double? AdherenceToDeliveryDates { get; set; }

    /// <summary>
    /// Gets or Sets SchedulingEfficiency
    /// </summary>
    [DataMember(Name="schedulingEfficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedulingEfficiency")]
    public double? SchedulingEfficiency { get; set; }

    /// <summary>
    /// Gets or Sets OccupancyRate
    /// </summary>
    [DataMember(Name="occupancyRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occupancyRate")]
    public double? OccupancyRate { get; set; }

    /// <summary>
    /// Gets or Sets SetupReduction
    /// </summary>
    [DataMember(Name="setupReduction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setupReduction")]
    public double? SetupReduction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationPlanningScenariosProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  NumberOfWorkplaces: ").Append(NumberOfWorkplaces).Append("\n");
      sb.Append("  ScheduledOperatingTime: ").Append(ScheduledOperatingTime).Append("\n");
      sb.Append("  PlannedProcessingTime: ").Append(PlannedProcessingTime).Append("\n");
      sb.Append("  PlannedExecutionTime: ").Append(PlannedExecutionTime).Append("\n");
      sb.Append("  NumberOfPlannedProductionOrders: ").Append(NumberOfPlannedProductionOrders).Append("\n");
      sb.Append("  PlannedLeadTime: ").Append(PlannedLeadTime).Append("\n");
      sb.Append("  MinimumLeadTimeWithSetup: ").Append(MinimumLeadTimeWithSetup).Append("\n");
      sb.Append("  NumberOfPartiallyPlannedProductionOrders: ").Append(NumberOfPartiallyPlannedProductionOrders).Append("\n");
      sb.Append("  AdherenceToDeliveryDates: ").Append(AdherenceToDeliveryDates).Append("\n");
      sb.Append("  SchedulingEfficiency: ").Append(SchedulingEfficiency).Append("\n");
      sb.Append("  OccupancyRate: ").Append(OccupancyRate).Append("\n");
      sb.Append("  SetupReduction: ").Append(SetupReduction).Append("\n");
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
