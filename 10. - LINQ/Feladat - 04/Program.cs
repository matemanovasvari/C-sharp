using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Channels;

namespace Feladat___04
{
    internal class Program
    {
        private static List<Movie> _movies = new List<Movie>();

        private static void LoadData()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            };

            options.Converters.Add(new DateFormatConverter());

            using (FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string jsonData = sr.ReadToEnd();

                    _movies = JsonSerializer.Deserialize<List<Movie>>(jsonData, options);
                }
            }
        }

        private static void WriteToConsole(string text, ICollection<Movie> movies)
        {
            Console.WriteLine(text);
            Console.WriteLine(string.Join('\n', _movies));
        }

        private static void WriteToConsole(string text, Movie movie)
        {
            Console.WriteLine(text);
            Console.WriteLine(movie);
        }

        static void Main(string[] args)
        {
            LoadData();
            WriteToConsole($"Data ({_movies.Count})", _movies);
        }

        // 1 - Hány film adatát dolgozzuk fel?
        int numberOfMovies = _movies.Count;

        // 2 - Mekkora bevételt hoztak a filmek Amerikában?
        int sumOfAmericanIncome = _movies.Sum(x => x.USGross.Value);

        // 3 - Mekkora bevételt hoztak a filmek Világszerte?
        long sumOfWorldwideIncome = _movies.Sum(x => x.WorldwideGross.Value);

        // 4 - Hány film jelent meg az 1990-es években?
        int numberOfFilmsFrom1990 = _movies.Where(x => x.ReleaseDate.Year >= 1990 && x.ReleaseDate.Year < 2000).Count();

        // 5 - Hányan szavaztak összessen az IMDB-n?
        double numberOfIMDBVotes = _movies.Sum(x => x.IMDBVotes.Value);

        // 6 - Hányan szavaztak átlagossan az IMDB-n?
        double averageIMDBVotes = _movies.Average(x => x.IMDBVotes.Value);

        // 7 - A filmek  világszerte átlagban mennyit hoztak a konyhára?
        double averageWorldwideIncome = _movies.Average(x => x.WorldwideGross.Value);

        // 8 - Hány filmet rendezett 'Christopher Nolan' ?
        int numberOfNolanMovies = _movies.Where(x => x.Director == "Christopher Nolan").Count();

        // 9 - Melyik filmeket rendezte 'James Cameron'?
        List<Movie> cameronMovies = _movies.Where(x => x.Director == "James Cameron").ToList();

        // 10 - Keresse ki a 'Fantasy' kaland (Adventure) zsáner kategóriájjú filmeket.
        List<Movie> fantasyAdventureMovies = _movies.Where(x => x.MajorGenre == "Adventure" && x.CreativeType == "Fantasy").ToList();

        // 11 - Kik rendeztek akció (Action) filmeket és mikor?
        List<DirectorAndReleaseDate> actionMovieDirectorsAndDate = _movies.Where(x => x.MajorGenre == "Action")
                                      .GroupBy(x => x.Director)
                                      .Select(x => new DirectorAndReleaseDate
                                      {
                                          MovieDirector = x.Key,
                                          MovieReleaseDate = x.Select(x => x.ReleaseDate).ToList()
                                      }).ToList();

        // 12 - 'Paramount Pictures' horror filmjeinek cime?
        List<string> paramountHorrorMovies = _movies.Where(x => x.MajorGenre == "Horror" && x.Distributor == "Paramount Pictures")
                                             .Select(x => x.Title)
                                             .ToList();

        // 13 - Van-e olyan film melyet 'Tom Cruise' rendezett?
        bool isThereMovieDirectedByCruise = _movies.Any(x => x.Director == "Tom Cruise");

        // 14 - A 'Little Miss Sunshine' filme mekkora össz bevételt hozott?
        long? littleMissSunshineIncome = _movies.Where(x => x.Title == "Little Miss Sunshine")
                                       .Sum(x => x.USDVDSales + x.WorldwideGross + x.USGross);

        // 15 - Hány olyan film van amely az IMDB-n 6 feletti osztályzatot ért el és a 'Rotten Tomatoes'-n pedig legalább 25-t?
        int numberOfMoviesWithGoodRating = _movies.Where(x => x.IMDBRating > 6 && x.RottenTomatoesRating >= 25).Count();

        // 16 - 'Michael Bay' filmjei átlagban mekkora bevételt hoztak?
        double michaelBayAverageIncome = _movies.Where(x => x.Director == "Michael Bay")
                                            .Average(x => x.USDVDSales.Value + x.USGross.Value + x.WorldwideGross.Value);

        // 17 - Melyek azok a 'Michael Bay' a 'Walt Disney Pictures' által forgalmazott fimek melyek legalább 150min hosszúak.
        List<Movie> bayAndWaltMovies = _movies.Where(x => x.Director == "Michael Bay" && x.Distributor == "Walt Disney Pictures" &&
                                                         x.RunningTime >= 150).ToList();

        // 18 - Listázza ki a forgalmazókat úgy, hogy mindegyik csak egyszer jelenjen meg!
        List<string> distributors = _movies.Where(x => x.Distributor != null)
                                   .Select(x => x.Distributor)
                                   .Distinct()
                                   .ToList();

        // 19 - Rendezze a filmeket az 'IMDB Votes' szerint  növekvő sorrendbe.
        List<Movie> moviesOrderedByIMDBVotes = _movies.OrderBy(x => x.IMDBVotes).ToList();

        // 20 - Rendezze a filmeket címük szerint csökkenő sorrendbe!
        List<Movie> moviesOrderedByTitle = _movies.OrderByDescending(x => x.Title).ToList();

        // 21 - Melyek azok a filmek melyek hossza meghaladja a 120 percet?
        List<Movie> moviesLongerThen120Minutes = _movies.Where(x => x.RunningTime > 120).ToList();

        // 22 - Hány film jelent meg december hónapban?
        List<Movie> moviesFromDecember = _movies.Where(x => x.ReleaseDate.Month == 12).ToList();

        // 23 - Egyes besorolásokban (Rating) hány film található?
        List<RatingAndCount> numberOfMoviesInEachRating = _movies.Where(x => x.MajorGenre != null)
                                      .GroupBy(x => x.Rating)
                                      .Select(x => new RatingAndCount
                                      {
                                          RatingGroup = x.Key,
                                          NumberOfMovies = x.Count()
                                      }).ToList();

        // 24 - Keresse ki azokat a filmeket melyeket 'Ron Howard' rendezett a 2000 években, 'PG-13' bsorolású,
        // lagalább 80 perc hosszú és az IMDB legalább 6.5 átlagot ért el.
        List<Movie> moviesMadeByRonHoward = _movies.Where(x => x.Director == "Ron Howard" &&
                                                      x.ReleaseDate.Year >= 2000 && x.ReleaseDate.Year < 2010 &&
                                                      x.Rating == "PG-13" &&
                                                      x.RunningTime >= 80 && x.IMDBRating >= 6.5
                                                      ).ToList();

        // 25 - A 'Lionsgate' kiadónál kik rendeztek filmeket?
        List<string> lionsgateDirectors = _movies.Where(x => x.Distributor == "Lionsgate")
                                                        .Select(x => x.Director)
                                                        .Distinct()
                                                        .ToList();

        // 26 - Az 'Universal' forgalmazó átlagban mennyit kültött film forgatására?
        double? averageUniversalCost = _movies.Where(x => x.Distributor == "Universal")
                                                .Average(x => x.ProductionBudget);

        // 27 - Az 'IMDB Votes' alapján melyek azok a filmek, melyeket többen értékeltek min 30 000-n?
        List<Movie> moviesWithMoreThan30000Votes = _movies.Where(x => x.IMDBVotes >= 30000).ToList();

        // 28 - Az 'American Pie' című filmnek hány része van?
        int numberOfEpisodesOfAmericanPie = _movies.Count(x => x.Title.Contains("American Pie"));

        // 29 - Van-e olyan film melynek a címében szerepel a 'fantasy' szó és a zsánere 'Adventure'?
        bool titleWithFantasyGenreAdventure = _movies.Any(x => x.Title.Contains("fantasy") && x.MajorGenre == "Adventure");

        // 30 - Átlagban hányan szavaztak az IMDB-n?
        double averageOfIMDBVotes = _movies.Average(x => x.IMDBVotes.Value);

        // 31 - Kik rendeztek a 'Warner Bros.' forgalmazónál dráma filmeket 1970 és 1975 közt melyre az 'IMDB Votes' alapján
        // többen szavaztak az átlagnál?
        List<string> warnerDirectors = _movies.Where(x => x.Distributor == "Warner Bros." && x.MajorGenre == "Drama" &&
                                                                    x.ReleaseDate.Year >= 1970 && x.ReleaseDate.Year <= 1975 &&
                                                                    x.IMDBVotes > averageOfIMDBVotes)
                                                         .Select(x => x.Director).ToList();

        // 32 - Van e olyan film amely karácsony napján jelent meg?
        bool isThereMovieThatReleasedOnChristmas = _movies.Any(x => x.ReleaseDate.Month == 12 && x.ReleaseDate.Day == 25);

        // 33 - 'Spider-Man' című filmek USA-ban mekkora bevételt hoztak?
        int? spiderManUSAIncomes = _movies.Where(m => m.Title.Contains("Spider Man"))
        .Sum(x => x.USDVDSales + x.USGross);

        // 34 - Keresse ki  szuperhősös (Super Hero) filmek címeit.
        List<string> superHeroMovies = _movies.Where(m => m.CreativeType == "Super Hero")
                                            .Select(m => m.Title).ToList();
    }
}
