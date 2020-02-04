using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SearchProductionOrders
    {
        /// <summary>
        /// Gets or Sets ActualEndDateUntil
        /// </summary>
        [DataMember(Name = "actualEndDateUntil", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actualEndDateUntil")]
        public DateTime? ActualEndDateUntil { get; set; }

        /// <summary>
        /// Gets or Sets ActualStartDateFrom
        /// </summary>
        [DataMember(Name = "actualStartDateFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "actualStartDateFrom")]
        public DateTime? ActualStartDateFrom { get; set; }

        /// <summary>
        /// Gets or Sets BasicEndDateUntil
        /// </summary>
        [DataMember(Name = "basicEndDateUntil", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "basicEndDateUntil")]
        public DateTime? BasicEndDateUntil { get; set; }

        /// <summary>
        /// Gets or Sets BasicStartDateFrom
        /// </summary>
        [DataMember(Name = "basicStartDateFrom", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "basicStartDateFrom")]
        public DateTime? BasicStartDateFrom { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ErpContextIds
        /// </summary>
        [DataMember(Name = "erpContextIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erpContextIds")]
        public List<string> ErpContextIds { get; set; }

        /// <summary>
        /// Gets or Sets MaterialNumbers
        /// </summary>
        [DataMember(Name = "materialNumbers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "materialNumbers")]
        public List<string> MaterialNumbers { get; set; }

        /// <summary>
        /// Gets or Sets ProductionOrderIds
        /// </summary>
        [DataMember(Name = "productionOrderIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionOrderIds")]
        public List<string> ProductionOrderIds { get; set; }

        /// <summary>
        /// Gets or Sets ProductionOrderNumbers
        /// </summary>
        [DataMember(Name = "productionOrderNumbers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionOrderNumbers")]
        public List<string> ProductionOrderNumbers { get; set; }

        /// <summary>
        /// Gets or Sets ProductionOrderSplits
        /// </summary>
        [DataMember(Name = "productionOrderSplits", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productionOrderSplits")]
        public List<string> ProductionOrderSplits { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchProductionOrders {\n");
            sb.Append("  ActualEndDateUntil: ").Append(ActualEndDateUntil).Append("\n");
            sb.Append("  ActualStartDateFrom: ").Append(ActualStartDateFrom).Append("\n");
            sb.Append("  BasicEndDateUntil: ").Append(BasicEndDateUntil).Append("\n");
            sb.Append("  BasicStartDateFrom: ").Append(BasicStartDateFrom).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ErpContextIds: ").Append(ErpContextIds).Append("\n");
            sb.Append("  MaterialNumbers: ").Append(MaterialNumbers).Append("\n");
            sb.Append("  ProductionOrderIds: ").Append(ProductionOrderIds).Append("\n");
            sb.Append("  ProductionOrderNumbers: ").Append(ProductionOrderNumbers).Append("\n");
            sb.Append("  ProductionOrderSplits: ").Append(ProductionOrderSplits).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
