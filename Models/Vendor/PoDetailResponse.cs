using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Vendor;

public class PoDetailResponse
{
    [JsonProperty("po", Required = Required.Always)]
    public int Po { get; set; }

    [JsonProperty("po_det", Required = Required.Always)]
    public int PoDet { get; set; }

    [JsonProperty("upa_prod_Id", Required = Required.Always)]
    public int UpaProdId { get; set; }

    [JsonProperty("bonus_percent", Required = Required.Always)]
    public double? BonusPercent { get; set; }

    [JsonProperty("qty", Required = Required.Always)]
    public int Qty { get; set; }

    [JsonProperty("bonus_qty")]
    public int? BonusQty { get; set; }

    [JsonProperty("total_delivery_qty")]
    public int? TotalDeliveryQty { get; set; }

    [JsonProperty("total_delivered")]
    public int? TotalDelivered { get; set; }

    [JsonProperty("upa_prod_name", Required = Required.Always)]
    public string UpaProdName { get; set; }

    [JsonProperty("tax")]
    public int? Tax { get; set; }

    [JsonProperty("unit_price", Required = Required.Always)]
    public double UnitPrice { get; set; }

    [JsonProperty("total_price_no_tax", Required = Required.Always)]
    public double TotalPriceNoTax { get; set; }

    [JsonProperty("toal_tax")]
    public double? ToalTax { get; set; }

    [JsonProperty("total_price_with_tax", Required = Required.Always)]
    public double TotalPriceWithTax { get; set; }
}
