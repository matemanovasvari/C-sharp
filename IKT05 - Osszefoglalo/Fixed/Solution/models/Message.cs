public abstract class Message
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

    public abstract MessageToSend FormatMessage();

    public abstract Task<Response> Send();
    public Message()
    {

    }
    public Message(string system, string firstName, string lastName, string mobileNumber, string messageText)
    {
        System = system;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        MessageText = messageText;
    }
}
