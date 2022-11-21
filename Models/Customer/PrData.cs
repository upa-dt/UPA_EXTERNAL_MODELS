using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class PrData
    {
        [JsonProperty("pr")]
        public int Pr { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("entity_name")]
        public string EntityName { get; set; }

        [JsonProperty("fund_account_id")]
        public int? FundAccountId { get; set; }

        [JsonProperty("fund_account_name")]
        public string FundAccountName { get; set; }

        [JsonProperty("warehouse_id")]
        public int WarehouseId { get; set; }

        [JsonProperty("warehouse_name")]
        public string WarehouseName { get; set; }

        [JsonProperty("warehouse_address")]
        public string WarehouseAddress { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("create_date")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("created_by_user")]
        public int CreatedByUser { get; set; }

        [JsonProperty("approved_by_user")]
        public int? ApprovedByUser { get; set; }

        [JsonProperty("approval_date")]
        public DateTime? ApprovalDate { get; set; }

        [JsonProperty("category_code")]
        public int CategoryCode { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("sent_up_by_entity_code")]
        public int? SentUpByEntityCode { get; set; }

        [JsonProperty("sent_up_by_entity_name")]
        public string SentUpByEntityName { get; set; }

        [JsonProperty("sent_up_by_user_code")]
        public int? SentUpByUserCode { get; set; }

        [JsonProperty("sent_up_by_user_name")]
        public string SentUpByUserName { get; set; }

        [JsonProperty("sent_time")]
        public DateTime? SentTime { get; set; }
    }
}
