using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses;

public class UserResponse
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("job")]
    public string Job { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
}