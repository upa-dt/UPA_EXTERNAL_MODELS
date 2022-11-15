using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Vendor;

public class PoSearchRequest : RequestBase
{
    /// <summary>
    /// Search Start Date
    /// Null Value means from begining
    /// </summary>
    [JsonProperty("fromDate")]
    public DateTime? FromDate { get; set; }
    /// <summary>
    /// Search End Date
    /// Null Value means to the Last PO, Null Means To Latest
    /// </summary>
    [JsonProperty("toDate")]
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// (Optional) Filter Po to Search For Specific Purchase Order, Null Means Don't Care
    /// </summary>
    [JsonProperty("filterPO")]
    public int? FilterPo { get; set; }

    /// <summary>
    /// Filter Po Status, Null Means Don't Care
    /// </summary>
    public PoStatusEnum? PoStatus { get; internal set; }
}
