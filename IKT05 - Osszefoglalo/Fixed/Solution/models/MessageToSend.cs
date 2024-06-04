
public class MessageToSend
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
}
