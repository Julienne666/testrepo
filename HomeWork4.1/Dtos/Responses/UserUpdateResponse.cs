using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses;

public class UserUpdateResponse
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("job")]
    public string Job { get; set; }

    [JsonProperty("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}