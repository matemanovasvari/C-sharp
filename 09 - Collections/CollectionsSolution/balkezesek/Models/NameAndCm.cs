public class NameAndCm
{


    public string Name { get; set; }

    public double HeightInCM { get; set; }

    public override string ToString()
    {
        return $"{Name}, {HeightInCM:F1}";
    }
}
