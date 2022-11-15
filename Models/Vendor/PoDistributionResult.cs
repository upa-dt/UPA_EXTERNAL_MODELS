using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPAExternalAPI.Models.Vendor;

public class PoDistributionResult
{
    [JsonProperty("po", Required = Required.DisallowNull)]
    public int? Po { get; set; }

    [JsonProperty("pr", Required = Required.DisallowNull)]
    public int? Pr { get; set; }

    [JsonProperty("customer_id", Required = Required.DisallowNull)]
    public int? CustomerId { get; set; }

    [JsonProperty("customer_name", Required = Required.DisallowNull)]
    public string CustomerName { get; set; }

    [JsonProperty("warehouse_Id", Required = Required.DisallowNull)]
    public long? WarehouseId { get; set; }

    [JsonProperty("warehouse_name", Required = Required.DisallowNull)]
    public string WarehouseName { get; set; }

    [JsonProperty("warehouse_address", Required = Required.DisallowNull)]
    public string WarehouseAddress { get; set; }

    [JsonProperty("customer_comment")]
    public string CustomerComment { get; set; }
}
