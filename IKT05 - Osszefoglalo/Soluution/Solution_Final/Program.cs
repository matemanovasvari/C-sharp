SendFormattedMessageAsync();

static async Task SendFormattedMessageAsync()
{
    DateTime actualDate = DateTime.Now;
    string filename = "messages";

    List<Message> readMessages = await FileService.ReadFromFileAsync<Message>(filename);
    List<MessageToSend> sentMessage = new List<MessageToSend>();
    MessageToSend valami = null;

    foreach (Message message in readMessages)
    {
        switch (message.System.ToLower())
        {
            case "ios":
                valami = new MessageToSend(new IOS(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText).ToString(), 0);
                break;
            case "android":
                valami = new MessageToSend(new Android(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText).ToString(), 1);
                break;
            case "windows":
                valami = new MessageToSend(new Windows(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText).ToString(), 2);
                break;
        }
        sentMessage.Add(valami);
    }

    List<Response> responses = new List<Response>();
    Response response = new Response();

    foreach (MessageToSend message in sentMessage)
    {
        response = await message.Send();
        responses.Add(response);
    }

    List<Response> successes = new List<Response>();
    List<Response> errors = new List<Response>();

    foreach(Response item in responses) 
    {
        if (item.Success)
        {
            successes.Add(item);
        }
        else
        {
            errors.Add(item);
        }
    }

    await FileService.WriteToTxtAsync<Response>(successes, $"delivered_{actualDate}");
    await FileService.WriteToTxtAsync<Response>(errors, $"delivered_{actualDate}");

    CreateReportAsync(successes, errors);
}

static async void CreateReportAsync(List<Response> successes, List<Response> errors)
{
    int number = 0;
    Report report = new Report();
    report.SuccessCount = successes.Count;
    report.Date = DateTime.Now;

    foreach(Response error in errors)
    {
        report.Errors.Add(new Error(error.ErrorMessage, 1));
    }

    await FileService.WriteToFileAsync([report], $"report_{DateTime.Now}");
}