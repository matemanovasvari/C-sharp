using System.Numerics;

public class TeamAndNames
{
    public string Team { get; set;}

    public List<string> Names { get; set;}

    public override string ToString()
    {
        return $"{Team}: {string.Join(", ", Names)}\n";
    }
}