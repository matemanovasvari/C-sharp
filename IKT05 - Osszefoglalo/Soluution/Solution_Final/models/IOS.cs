public class IOS : Message
{
    public override MessageToSend FormatMessage()
    {
        MessageToSend message = new MessageToSend($"{System}|{FirstName}|{LastName}|{MobileNumber}|{MessageText}", 0);
        return message;
    }

    public override async Task<Response> Send()
    {
        Response response = await HttpService.SendPostRequestAsync<Response>("api/send/ios", FormatMessage());
        return response;
    }

    public IOS()
    {

    }

    public IOS(string system, string firstName, string lastName, string mobileNumber, string messageText) : base(system, firstName, lastName, mobileNumber, messageText)
    {
    }
}