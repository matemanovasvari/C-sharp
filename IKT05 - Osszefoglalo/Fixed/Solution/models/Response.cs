public class Response
{
    [JsonPropertyName("success")]
    public bool IsSuccess { get; set; }

    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }

    [JsonPropertyName("dateTime")]
    public DateTime Date { get; set; }

    public override string ToString()
    {
        if (IsSuccess)
        {
            return $"{IsSuccess} - {Date}";
        }
        else
        {
            return $"{IsSuccess} - {ErrorMessage} - {Date}";
        }
    }
}
