using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPAExternalAPI.Models.Vendor;

public class PoDistributionResultDetails
{
    [JsonProperty("po", Required = Required.Always)]
    public int Po { get; set; }

    [JsonProperty("pr", Required = Required.Always)]
    public int Pr { get; set; }

    [JsonProperty("po_det_id", Required = Required.Always)]
    public int PoDetId { get; set; }

    [JsonProperty("pr_det_id", Required = Required.Always)]
    public int PrDetId { get; set; }

    [JsonProperty("upa_product_id", Required = Required.Always)]
    public int UpaProductId { get; set; }

    [JsonProperty("upa_product_name", Required = Required.Always)]
    public string UpaProductName { get; set; }

    [JsonProperty("qty", Required = Required.Always)]
    public int Qty { get; set; }

    [JsonProperty("bonus_qty")]
    public int? BonusQty { get; set; }

    [JsonProperty("total_qty_with_bonus", Required = Required.Always)]
    public int TotalQtyWithBonus { get; set; }

    [JsonProperty("received_qty")]
    public int? ReceivedQty { get; set; }

    [JsonProperty("remianing_qty")]
    public int? RemianingQty { get; set; }

    [JsonProperty("item_price", Required = Required.Always)]
    public double ItemPrice { get; set; }

    [JsonProperty("item_tax", Required = Required.Always)]
    public double ItemTax { get; set; }

    [JsonProperty("warehouse_id", Required = Required.Always)]
    public int WarehouseId { get; set; }


    [JsonProperty("entity_id", Required = Required.Always)]
    public int entity_id { get; set; }


    [JsonProperty("entity_name", Required = Required.Always)]
    public string entity_name { get; set; }


    [JsonProperty("warehouse_name", Required = Required.Always)]
    public string warehouse_name { get; set; }


    [JsonProperty("warehouse_address", Required = Required.Always)]
    public string warehouse_address { get; set; }


    [JsonProperty("pr_comment")]
    public string pr_comment { get; set; }
}
