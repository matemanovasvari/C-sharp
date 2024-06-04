public interface IMessage
{
    public string System { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public string MessageText { get; set; }

    public MessageToSend FormatMessage();
    public Task<Response> Send();

}