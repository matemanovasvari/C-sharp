using System.Dynamic;

public class NameAndReleaseDate
{
    public string Name { get; set; }

    public int ReleaseDate { get; set; }

    public NameAndReleaseDate(string name, int releaseDate)
    {
        Name = name;
        ReleaseDate = releaseDate;
    }

    public NameAndReleaseDate()
    {
    }
}