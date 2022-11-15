namespace UPAExternalAPI.Models;

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

public class AuthenticateRequest
{
    [JsonProperty("api_key")]
    [Required]
    public string API_KEY { get; set; }
    [JsonProperty("api_user")]
    [Required]
    public string API_USER { get; set; }
    [JsonProperty("api_password")]
    [Required]
    public string API_PASSWORD { get; set; }
}
