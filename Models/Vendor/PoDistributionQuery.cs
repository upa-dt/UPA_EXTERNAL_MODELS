using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UPAExternalAPI.Models.Vendor;

public class PoDistributionQuery
{
    /// <summary>
    /// Purchase Order Number
    /// </summary>
    [JsonProperty("po")]
    public int po { get; set; }
    /// <summary>
    /// (Optional) Purchase Reuquest Number
    /// </summary>
    [JsonProperty("pr")]
    public int? pr { get; set; }
    /// <summary>
    /// Customer Id
    /// </summary>
    [JsonProperty("customer_id")]
    public int? customer_id { get; set; }

    /// <summary>
    /// UPA Product Id
    /// </summary>
    [JsonProperty("upa_prod_id")]
    public int? upa_prod_id { get; set; }
}

public class PoDistributionDetailsQuery
{
    /// <summary>
    /// Purchase Order Number
    /// </summary>
    [JsonProperty("po")]
    [JsonRequired]
    [Required(ErrorMessage = "Purchase Order Number Required")]
    public int po { get; set; }
    /// <summary>
    /// Purchase Reuquest Number
    /// </summary>
    [JsonProperty("pr", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonRequired]
    //[Required(ErrorMessage = "Purchase Reuquest Number Required")]
    public int? pr { get; set; }
    /// <summary>
    /// Customer Id
    /// </summary>
    [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonRequired]
    //[Required(ErrorMessage = "Customer Id Required")]
    public int? customer_id { get; set; }

    /// <summary>
    /// Warehouse Id
    /// </summary>
    [JsonProperty("warehouse_id", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonRequired]
    //[Required(ErrorMessage = "Warehouse Id Required")]
    public int? warehouse_id { get; set; }
}
