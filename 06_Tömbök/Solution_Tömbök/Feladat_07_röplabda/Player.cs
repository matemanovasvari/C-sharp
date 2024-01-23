public class Player{
    public string Name { get; set; }

    public double Height { get; set; }

    public int Points { get; set; }

    public Player()
    {
    }

    public Player(string name, double height, int points)
    {
        Name = name;
        Height = height;
        Points = points;
    }

    public override string ToString()
    {
        return $"A játékos neve: {Name}, magassága: {Height}, szerzett pontjai: {Points}";
    }
}