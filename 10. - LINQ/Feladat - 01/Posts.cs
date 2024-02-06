using System.Data;

public class Posts
{

    public string Position { get; set; }

    public int NumberOfPlayersInPosition { get; set; }

    public Posts(string position, int numberOfPlayersInPosition)
    {
        Position = position;
        NumberOfPlayersInPosition = numberOfPlayersInPosition;
    }

    public Posts()
    {
    }
}