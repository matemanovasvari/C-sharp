Motorcycle honda = new Motorcycle();
honda.Manufacturer = "Honda";
honda.Model = "CB 600F Hornet";
honda.ProductionYear = 2008;

Movie movie = new Movie();
movie.MovieTitle = "Interstellar";
movie.MovieDirector = "Christopher Nolan";
movie.ProductionYear = 2014;
movie.MainActor = "Metthew McConaughey";
movie.MovieCost = "165 million USD";

Siege r6 = new Siege();
r6.NumberOfOperators = 65;
r6.DefenderMain = "Smoke";
r6.AttackerMain = "IQ";
r6.ProductionYear = 2015;
r6.GameStudio = "Ubisoft";

Console.WriteLine(honda);
Console.WriteLine($"\n{movie}");
Console.WriteLine($"\n{r6}");