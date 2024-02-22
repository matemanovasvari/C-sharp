public class PlayersBelowAverage
{
    public string Name { get; set; }

    public int Height { get; set; }

    public double AverageHeight { get; set; }

    public double Difference => AverageHeight - Height;

    public override string ToString()
    {
        return $"Játékos neve: {Name}, magassága: {Height} és {AverageHeight:F2}-vel alacsonyabb az átlagnál";
    }
}