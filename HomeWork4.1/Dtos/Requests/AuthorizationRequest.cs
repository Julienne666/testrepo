using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Requests;

public class AuthorizationRequest
{
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }
}