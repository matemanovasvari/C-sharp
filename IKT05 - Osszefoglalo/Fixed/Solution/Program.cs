await SendFormattedMessageAsync();

static async Task SendFormattedMessageAsync()
{
    DateTime actualDate = DateTime.Now;

    List<Message> readMessages = FormatMessageBeforeSending(await FileService.ReadFromFileAsync<ReadMessage>("messages"));

    List<Response> responses = new List<Response>();
    Response response = new Response();

    foreach (Message message in readMessages)
    {
        response = await message.Send();
        responses.Add(response);
    }

    List<Response> successes = new List<Response>();
    List<Response> errors = new List<Response>();

    foreach (Response item in responses)
    {
        if (item.IsSuccess)
        {
            successes.Add(item);
        }
        else
        {
            errors.Add(item);
        }
    }

    await FileService.WriteToTxtAsync<Response>(successes, $"delivered_{actualDate.ToString("yyyy-MM-dd")}");
    await FileService.WriteToTxtAsync<Response>(errors, $"not_delivered_{actualDate.ToString("yyyy-MM-dd")}");

    CreateReportAsync(successes, errors);
}

static async void CreateReportAsync(List<Response> successes, List<Response> errors)
{
    int number = 0;
    Report report = new Report();
    report.SuccessCount = successes.Count;
    report.Date = DateTime.Now;

    foreach (Response error in errors)
    {
        report.Errors.Add(new Error(error.ErrorMessage, 1));
    }

    await FileService.WriteToFileAsync([report], $"report_{DateTime.Now.ToString("yyyy-MM-dd")}");
}

static List<Message> FormatMessageBeforeSending(List<ReadMessage> messages)
{
    List<Message> formattedMesssages = new List<Message>();
    Message system = null;

    foreach (ReadMessage message in messages)
    {
        switch (message.System.ToLower())
        {
            case "ios":
                system = new IOS(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText);
                break;
            case "android":
                system = new Android(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText);
                break;
            case "windows":
                system = new Windows(message.System, message.FirstName, message.LastName, message.MobileNumber, message.MessageText);
                break;
        }
        formattedMesssages.Add(system);
    }
    return formattedMesssages;
}