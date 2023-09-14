public class Siege
{
    public int ProductionYear { get; set; }
    public int NumberOfOperators { get; set; }
    public string DefenderMain { get; set; }
    public string AttackerMain { get; set; }
    public string GameStudio { get; set; }

    public override string ToString()
    {
        return $"{ProductionYear}, {NumberOfOperators}, {DefenderMain}, {AttackerMain}, {GameStudio}";
    }

}
