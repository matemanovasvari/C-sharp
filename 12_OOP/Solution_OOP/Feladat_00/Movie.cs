public class Movie
{
    public string MovieTitle { get; set; }
    public string MovieDirector { get; set; }
    public string MainActor { get; set; }
    public int ProductionYear { get; set; }
    public string MovieCost { get; set; }

    public override string ToString()
    {
        return $"{this.MovieTitle}, {this.MovieDirector}, {this.MainActor}, {this.ProductionYear}, {this.MovieCost}";
    }
}
