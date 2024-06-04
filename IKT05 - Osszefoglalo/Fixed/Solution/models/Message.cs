
public abstract class Message : IMessage
{
    public string System {  get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MobileNumber { get; set; }

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
