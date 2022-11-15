using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Customer;

public class PrSearchRequest : RequestBase
{
    /// <summary>
    /// Search Start Date
    /// Null Value means from begining
    /// </summary>
    [JsonProperty("fromDate")]
    public DateTime? FromDate { get; set; }
    /// <summary>
    /// Search End Date
    /// Null Value means to the Last PO
    /// </summary>
    [JsonProperty("toDate")]
    public DateTime? ToDate { get; set; }


    /// <summary>
    /// (Optional) Filter Pr to Search For Specific Purchase Request, Null Means Don't Care
    /// </summary>
    [JsonProperty("filterPr")]
    public int? FilterPr { get; set; }

    /// <summary>
    /// Include Entity Childrens in Search  
    /// </summary>
    [JsonProperty("includeChildren")]
    public bool IncludeChildren { get; set; }
}
