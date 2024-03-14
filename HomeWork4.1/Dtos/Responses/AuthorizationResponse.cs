using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses;

public class AuthorizationResponse
{
    [JsonProperty("token")]
    public string Token { get; set; }
}