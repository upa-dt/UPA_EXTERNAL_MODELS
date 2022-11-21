using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace UPA_EXTERNAL_MODELS.Models.Customer
{
    public partial class InventoryContentItem
    {
        [JsonProperty("inventory_transaction_id")]
        public int InventoryTransactionId { get; set; }

        [JsonProperty("custody_type_id")]
        public int CustodyTypeId { get; set; }

        [JsonProperty("custody_name")]
        public string CustodyName { get; set; }

        [JsonProperty("inventory_update_date")]
        public DateTimeOffset InventoryUpdateDate { get; set; }

        [JsonProperty("warehouse_id")]
        public int WarehouseId { get; set; }

        [JsonProperty("upa_product_id")]
        public int UpaProductId { get; set; }

        [JsonProperty("owner_entity_id")]
        public int OwnerEntityId { get; set; }

        [JsonProperty("upa_product_name")]
        public string UpaProductName { get; set; }

        [JsonProperty("OrigQty")]
        public int? OrigQty { get; set; }

        [JsonProperty("is_local")]
        public int? IsLocal { get; set; }

        [JsonProperty("item_price")]
        public double ItemPrice { get; set; }

        [JsonProperty("OrigBonus")]
        public int? OrigBonus { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("fk_dosageForm")]
        public int? FkDosageForm { get; set; }

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

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("auxGtinList")]
        public object AuxGtinList { get; set; }

        [JsonProperty("cur_qty")]
        public int? CurQty { get; set; }

        [JsonProperty("category_name_en")]
        public string CategoryNameEn { get; set; }

        [JsonProperty("category_name_ar")]
        public string CategoryNameAr { get; set; }

        [JsonProperty("dosage_arabic")]
        public string DosageArabic { get; set; }

        [JsonProperty("dosage_english")]
        public string DosageEnglish { get; set; }

        [JsonProperty("OriginName")]
        public string OriginName { get; set; }

        [JsonProperty("delivery_date")]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty("acceptance_date")]
        public DateTime? AcceptanceDate { get; set; }

        [JsonProperty("userId_confirmed_delivery")]
        public int? UserIdConfirmedDelivery { get; set; }

        [JsonProperty("userInfo_confirmed_delivery")]
        public string UserInfoConfirmedDelivery { get; set; }

        [JsonProperty("userId_confirmed_acceptance")]
        public int? UserIdConfirmedAcceptance { get; set; }

        [JsonProperty("userInfo_confirmed_acceptance")]
        public string UserInfoConfirmedAcceptance { get; set; }
    }
}
