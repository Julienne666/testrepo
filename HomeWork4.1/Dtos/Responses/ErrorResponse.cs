using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses;

public class ErrorResponse
{
    [JsonProperty("error")]
    public string ErrorMessage { get; set; }
}