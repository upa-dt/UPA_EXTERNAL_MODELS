using Newtonsoft.Json;

namespace UPAExternalAPI.Models;

public class RequestBase
{
    /// <summary>
    /// Offset Record From Total Records ,  Default Zero if null
    /// </summary>
    [JsonProperty("offset")]
    public int? Offset { get; set; }
    /// <summary>
    /// Maximum Number of Records returned, Default 25 
    /// Maximum 100, Except In some cases for large DTO
    /// </summary>
    [JsonProperty("maxCount")]
    public int? MaxCount { get; set; }
}
