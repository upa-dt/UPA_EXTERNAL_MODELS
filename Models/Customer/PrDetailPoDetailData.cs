using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class PrDetailPoDetailData
    {
        [JsonProperty("pr")]
        public int Pr { get; set; }

        [JsonProperty("po")]
        public int Po { get; set; }

        [JsonProperty("pr_det_id")]
        public int PrDetId { get; set; }

        [JsonProperty("po_det_id")]
        public int PoDetId { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("bonus_qty")]
        public int? BonusQty { get; set; }

        [JsonProperty("received_qty")]
        public int? ReceivedQty { get; set; }

        [JsonProperty("received_bonus")]
        public int? ReceivedBonus { get; set; }

        [JsonProperty("remain_qty")]
        public int? RemainQty { get; set; }

        [JsonProperty("remain_bonus")]
        public int? RemainBonus { get; set; }

        [JsonProperty("upa_product_code")]
        public int UpaProductCode { get; set; }

        [JsonProperty("upa_product_name")]
        public string UpaProductName { get; set; }

        [JsonProperty("upa_product_description")]
        public string UpaProductDescription { get; set; }
    }
}
