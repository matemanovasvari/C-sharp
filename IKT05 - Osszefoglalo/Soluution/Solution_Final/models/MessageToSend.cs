public class MessageToSend : Message
{
    public string Content { get; set; }

    public int System { get; set; }

    public MessageToSend()
    {
        
    }

    public MessageToSend(string content, int system)
    {
        Content = content;
        System = system;
    }

    public override MessageToSend FormatMessage()
    {
        throw new NotImplementedException();
    }

    public override Task<Response> Send()
    {
        throw new NotImplementedException();
    }
}
