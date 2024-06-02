public class Windows : Message
{
        public override MessageToSend FormatMessage()
        {
            MessageToSend message = new MessageToSend($"{System}*{FirstName}*{LastName}*{MobileNumber}*{MessageText}", 2);
            return message;
        }

        public override async Task<Response> Send()
        {
            Response response = await HttpService.SendPostRequestAsync<Response>("api/send/ios", FormatMessage());
            return response;
        }

        public Windows()
        {

        }

        public Windows(string system, string firstName, string lastName, string mobileNumber, string messageText) : base(system, firstName, lastName, mobileNumber, messageText)
        {
        }
    }
