using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Vendor;
public partial class GetReturnedItemsResponse
{
    [JsonProperty("ri", Required = Required.Always)]
    [JsonRequired]
    public int Ri { get; set; }

    [JsonRequired]
    [JsonProperty("ri_ItemId", Required = Required.Always)]
    public int RiItemId { get; set; }

    [JsonRequired]
    [JsonProperty("pr_det_id", Required = Required.Always)]
    public int PrDetId { get; set; }

    [JsonRequired]
    [JsonProperty("po_det_id", Required = Required.Always)]
    public int PoDetId { get; set; }

    [JsonProperty("transaction_id")]
    public int? TransactionId { get; set; }

    [JsonRequired]
    [JsonProperty("upa_product_id", Required = Required.Always)]
    public int UpaProductId { get; set; }

    [JsonProperty("GTIN")]
    public string Gtin { get; set; }
    [JsonRequired]
    [JsonProperty("userId_confirmed_delivery", Required = Required.Always)]
    public int UserIdConfirmedDelivery { get; set; }

    [JsonProperty("userInfo_confirmed_delivery", Required = Required.Always)]
    [JsonRequired]
    public string UserInfoConfirmedDelivery { get; set; }

    [JsonProperty("userId_confirmed_rejection", Required = Required.Always)]
    [JsonRequired]
    public int UserIdConfirmedRejection { get; set; }

    [JsonRequired]
    [JsonProperty("userInfo_confirmed_rejection", Required = Required.Always)]
    public string UserInfoConfirmedRejection { get; set; }

    [JsonRequired]
    [JsonProperty("rejection_date", Required = Required.Always)]
    public DateTime RejectionDate { get; set; }

    [JsonRequired]
    [JsonProperty("qty", Required = Required.Always)]
    public int Qty { get; set; }

    [JsonProperty("bonus")]
    public int? Bonus { get; set; }

    [JsonProperty("OriginName", Required = Required.DisallowNull)]
    public string OriginName { get; set; }

    [JsonProperty("trade_name")]
    public string TradeName { get; set; }

    [JsonRequired]
    [JsonProperty("upa_product_name", Required = Required.Always)]
    public string UpaProductName { get; set; }

    [JsonProperty("itemCountPerUnit")]
    public double? ItemCountPerUnit { get; set; }

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
    public double? MainQtyByUnit { get; set; }

    [JsonProperty("bonusQtyByUnit")]
    public double? BonusQtyByUnit { get; set; }

    [JsonProperty("dosage_arabic")]
    public string DosageArabic { get; set; }

    [JsonProperty("dosage_english")]
    public string DosageEnglish { get; set; }
}
