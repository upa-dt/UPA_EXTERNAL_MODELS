
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace UPA_EXTERNAL_MODELS.Models.Common
{
    public partial class RI_DetailData
    {
        [JsonProperty("ser")]
        public int Ser { get; set; }

        [JsonProperty("ri")]
        public int Ri { get; set; }

        [JsonProperty("ri_ItemId")]
        public int RiItemId { get; set; }

        [JsonProperty("pr_det_id")]
        public int PrDetId { get; set; }

        [JsonProperty("po_det_id")]
        public int PoDetId { get; set; }

        [JsonProperty("upa_product_id")]
        public int UpaProductId { get; set; }

        [JsonProperty("GTIN")]
        public string Gtin { get; set; }

        [JsonProperty("item_status")]
        public int ItemStatus { get; set; }

        [JsonProperty("item_status_name")]
        public string ItemStatusName { get; set; }

        [JsonProperty("userId_confirmed_delivery")]
        public int? UserIdConfirmedDelivery { get; set; }

        [JsonProperty("userInfo_confirmed_delivery")]
        public string UserInfoConfirmedDelivery { get; set; }

        [JsonProperty("userId_confirmed_accceptance")]
        public int? UserIdConfirmedAccceptance { get; set; }

        [JsonProperty("userInfo_confirmed_acceptance")]
        public string UserInfoConfirmedAcceptance { get; set; }

        [JsonProperty("acceptance_date")]
        public DateTime? AcceptanceDate { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("bonus")]
        public int? Bonus { get; set; }

        [JsonProperty("item_price")]
        public double ItemPrice { get; set; }

        [JsonProperty("item_tax")]
        public double ItemTax { get; set; }

        [JsonProperty("upa_fee_value")]
        public double UpaFeeValue { get; set; }

        [JsonProperty("item_final_price_no_tax")]
        public double ItemFinalPriceNoTax { get; set; }

        [JsonProperty("itam_total_tax")]
        public int ItamTotalTax { get; set; }

        [JsonProperty("grand_total_price")]
        public double GrandTotalPrice { get; set; }

        [JsonProperty("OriginName")]
        public string OriginName { get; set; }

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("upa_product_name")]
        public string UpaProductName { get; set; }

        [JsonProperty("itemCountPerUnit")]
        public int? ItemCountPerUnit { get; set; }

        [JsonProperty("forcedPrice")]
        public double? ForcedPrice { get; set; }

        [JsonProperty("pharmaPrice")]
        public double? PharmaPrice { get; set; }

        [JsonProperty("batchNumber")]
        public string BatchNumber { get; set; }

        [JsonProperty("manDate")]
        public DateTime? ManDate { get; set; }

        [JsonProperty("expDate")]
        public DateTime? ExpDate { get; set; }

        [JsonProperty("mainQtyByUnit")]
        public int? MainQtyByUnit { get; set; }

        [JsonProperty("bonusQtyByUnit")]
        public int? BonusQtyByUnit { get; set; }

        [JsonProperty("dosage_arabic")]
        public string DosageArabic { get; set; }

        [JsonProperty("dosage_english")]
        public string DosageEnglish { get; set; }
    }
}
