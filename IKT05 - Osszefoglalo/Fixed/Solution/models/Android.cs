public class Android : Message
{
    public override MessageToSend FormatMessage()
    {
        MessageToSend message = new MessageToSend($"{System}#{FirstName}#{LastName}#{MobileNumber}#{MessageText}", 1);
        return message;
    }

    public override async Task<Response> Send()
    {
        Response response = await HttpService.SendPostRequestAsync<Response>("api/send/android", FormatMessage());
        return response;
    }

    public Android()
    {

    }

    public Android(string system, string firstName, string lastName, string mobileNumber, string messageText) : base(system, firstName, lastName, mobileNumber, messageText)
    {
    }
}