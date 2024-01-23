using Custom.Library.ConsoleExtension;

const int NUMBER_OF_PLAYERS  = 6;

Player[] players = GetPlayers();

double averageHeight = players.Average(x => x.Height);
Player[] belowAverageHeightPlayers = players.Where(x => x.Height == averageHeight).ToArray();
Console.WriteLine("Átlagnál alacsonyabb játékos(ok)");
PrintPlayerToConsole(belowAverageHeightPlayers);

int numberOfPlayersAboveAverageHeight = players.Count(x => x.Height > averageHeight);
double percentOfPlayersTallerThenAverage = numberOfPlayersAboveAverageHeight / NUMBER_OF_PLAYERS * 100;
Console.WriteLine($"A csapat {percentOfPlayersTallerThenAverage:F2}%-a magasabb az átlagnál");

int sumOfPoints = players.Sum(x => x.Points);
Console.WriteLine($"A szezonban szerzett összpontszám: {sumOfPoints}");

int maxPoints = players.Max(x => x.Points);
Player[] playerWithMaxPoints = players.Where(x => x.Points == maxPoints).ToArray();
Console.WriteLine("Legtöbb pontot szerző játékos: ");
PrintPlayerNameToConsole(playerWithMaxPoints);

int minPoints = players.Max(x => x.Points);
Player[] playerWithMinPoints = players.Where(x => x.Points == minPoints).ToArray();
Console.WriteLine("Legkevesebb pontot szerző játékos: ");
PrintPlayerNameToConsole(playerWithMinPoints);

Player[] GetPlayers(){
    Player[] players = new Player[NUMBER_OF_PLAYERS];

    for(int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Kérem adja meg a játékos nevét: ");
        double height = ExtendedConsole.ReadDouble(150, "Kérem adja meg a játékos magasságát: ");
        int points = ExtendedConsole.ReadInteger("Kérem adja meg a játékos szerzett pontjait: ");

        players[i] = new Player(name, height, points);
    };
    
    return players;
}

void PrintPlayerToConsole(Player[] players)
{
    foreach(Player player in players)
    {
        Console.WriteLine(player);
    };
}

void PrintPlayerNameToConsole(Player[] players)
{
    foreach (Player player in players)
    {
        Console.WriteLine(player.Name);
    };
}