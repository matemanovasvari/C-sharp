
using System.Text.Json.Serialization;

public class Response
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }

    [JsonPropertyName("dateTime")]
    public DateTime DateTime { get; set; }
}
