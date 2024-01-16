public class Player
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Player()
    {

    }

    public Player(string name, int points)
    {
        Name = name;
        Points = points;
    }
}