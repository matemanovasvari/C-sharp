public class RatingAndCount
{
    public string RatingGroup { get; set; }

    public int NumberOfMovies { get; set; }
    public RatingAndCount()
    {
    }

    public RatingAndCount(string ratingGroup, int numberOfMovies)
    {
        RatingGroup = ratingGroup;
        NumberOfMovies = numberOfMovies;
    }
}