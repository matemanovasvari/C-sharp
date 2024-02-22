using System.Numerics;

public class Player
{

    public string Name { get; set; }

    public int Height { get; set; }

    public string Position { get; set; }

    public string Nationality { get; set; }

    public string Team { get; set; }

    public string Country { get; set; }

    public Player(string name, int height, string position, string nationality, string team, string country)
    {
        Name = name;
        Height = height;
        Position = position;
        Nationality = nationality;
        Team = team;
        Country = country;
    }

    public Player()
    {
    }

    public override string ToString()
    {
        return $"{Name}\t{Height}\t{Position}\t{Nationality}\t{Team}\t{Country}";
    }
}