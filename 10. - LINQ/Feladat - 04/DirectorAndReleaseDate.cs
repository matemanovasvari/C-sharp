using System;
using System.Collections.Generic;

public class DirectorAndReleaseDate
{
    public string MovieDirector {  get; set; }

    public List<DateTime> MovieReleaseDate { get; set; }
    public DirectorAndReleaseDate(string movieDirector, List<DateTime> movieReleaseDate)
    {
        MovieDirector = movieDirector;
        MovieReleaseDate = movieReleaseDate;
    }

    public DirectorAndReleaseDate()
    {
    }
}