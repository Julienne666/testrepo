using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses;

public class RegistrationResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("token")]
    public string Token { get; set; }
}