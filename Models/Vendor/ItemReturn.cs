using Newtonsoft.Json;

namespace UPAExternalAPI.Models.Vendor;

public class ItemReturn
{
    /// <summary>
    /// Array of Reception Invoice Item Id , Optained by call to getReturnedItems
    /// </summary>
    [JsonProperty("ri_ItemId_list")]
    public List<int> ri_ItemId_list { get; set; }
}
