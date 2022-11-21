using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class PrItemData
    {
        /// <summary>
        /// Purchase Request Detail ID
        /// </summary>
        [JsonProperty("det_id")]
        public int PrDetId { get; set; }
        /// <summary>
        /// Purchase Request Number
        /// </summary>
        [JsonProperty("pr")]
        public int Pr { get; set; }
        /// <summary>
        /// UPA Product Code
        /// </summary>
        [JsonProperty("upa_prod_code")]
        public int UpaProdCode { get; set; }
        /// <summary>
        /// Upa Product Name
        /// </summary>
        [JsonProperty("upa_prod_name")]
        public string UpaProdName { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("qty")]
        public int Qty { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }
        /// <summary>
        /// Total Price
        /// </summary>
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        /// <summary>
        /// Tax Percent
        /// </summary>
        [JsonProperty("tax_percent")]
        public double? TaxPercent { get; set; }

        [JsonProperty("total_tax")]
        public double? TotalTax { get; set; }

        [JsonProperty("bonus_percent")]
        public double? BonusPercent { get; set; }

        [JsonProperty("last_qty_by_entity_id")]
        public int? LastQtyByEntityId { get; set; }

        [JsonProperty("last_qty_by_entity_name")]
        public string LastQtyByEntityName { get; set; }

        [JsonProperty("is_deleted")]
        public int? IsDeleted { get; set; }

        [JsonProperty("last_qty_date")]
        public DateTime? LastQtyDate { get; set; }

        [JsonProperty("request_unit")]
        public int? RequestUnit { get; set; }
    }
}
