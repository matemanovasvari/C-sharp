public class NameAndWage
{
    public string Name { get; set; }

    public int Wage { get; set; }

    public override string ToString()
    {
        return $"{Name}\t{Wage}";
    }
}