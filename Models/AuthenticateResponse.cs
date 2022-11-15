namespace UPAExternalAPI.Models;

using Newtonsoft.Json;

public class AuthenticateResponse
{
    [JsonProperty("token")]
    public string Token { get; set; }
    [JsonProperty("otp")]
    public string OTP { get; set; }

}