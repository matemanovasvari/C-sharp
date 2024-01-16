using Custom.Library.ConsoleExtension;

const int NUMBER_OF_PLAYERS  = 5;

Player[] players = GetPlayers();

int sumOfPoints = players.Sum(x => x.Points);
Console.WriteLine($"Az összes pont amit a csapat a szezonban szerzett: {sumOfPoints}");

Console.WriteLine("A legtöbb pontot szerző játékos:\n");
int maxPoints = players.Max(x => x.Points);
Player[] playerThatHasMaxPoints = players.Where(x => x.Points == maxPoints).ToArray();
PrintPlayersToConsole(playerThatHasMaxPoints);

Console.WriteLine("A legtöbb pontot szerző játékos:\n");
int minPoints = players.Min(x => x.Points);
Player[] playerThatHasMinPoints = players.Where(x => x.Points == minPoints).ToArray();
PrintPlayersToConsole(playerThatHasMinPoints);

double averageOfPoints = players.Average(x => x.Points);
int numberOfPlayersThatAreBelowAverage = players.Count(x => x.Points < averageOfPoints);
Console.WriteLine($"{numberOfPlayersThatAreBelowAverage} játékos teljesített átlag alatt");

Console.WriteLine("Átlag feletti játékosok:\n");
Player[] playersThatAreAboveAverage = players.Where(x => x.Points > averageOfPoints).ToArray();
PrintPlayersToConsole(playersThatAreAboveAverage);

Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];

    for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a játékos nevét: ");
        int point = ExtendedConsole.ReadInteger("Adja meg, hogy hágy pontot szerzett a játékos: ");

        players[i] = new Player(name, point);
    }
    return players;
}

void PrintPlayersToConsole(Player[] players)
{
    foreach (Player player in players)
    {
        Console.WriteLine($"A játékos neve: {player.Name}, A játékos pontjai: {player.Points}");
    }
}