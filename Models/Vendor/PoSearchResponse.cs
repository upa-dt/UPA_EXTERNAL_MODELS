using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Vendor;

public class PoSearchResponse
{
    [JsonProperty("po", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
    public int? Po { get; set; }

    [JsonProperty("po_name", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
    public string PoName { get; set; }

    [JsonProperty("issue_date", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? IssueDate { get; set; }

    [JsonProperty("tax")]
    public double? Tax { get; set; }

    [JsonProperty("total", Required = Required.Always)]
    public double? Total { get; set; }

    [JsonProperty("toal_with_tax", Required = Required.Always)]
    public double? ToalWithTax { get; set; }

    [JsonProperty("status_code", Required = Required.Always)]
    public int? StatusCode { get; set; }

    [JsonProperty("status_name", Required = Required.Always)]
    public string StatusName { get; set; }

    [JsonProperty("items_count")]
    public int? ItemsCount { get; set; }
}
