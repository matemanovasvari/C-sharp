public class ReadMessage
{
    [JsonPropertyName("system")]
    public string System { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public string LastName { get; set; }

    [JsonPropertyName("mobileNumber")]
    public string MobileNumber { get; set; }

    [JsonPropertyName("message")]
    public string MessageText { get; set; }

    public ReadMessage()
    {
        
    }

    public ReadMessage(string system, string firstName, string lastName, string mobileNumber, string messageText)
    {
        System = system;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        MessageText = messageText;
    }
}