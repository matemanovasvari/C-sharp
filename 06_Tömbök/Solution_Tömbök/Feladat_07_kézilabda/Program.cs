using Custom.Library.ConsoleExtension;

const int NUMBER_OF_PLAYERS = 6;

Player[] players = GetPlayers();

double averageOfPoints = players.Average(x => x.Goals);
int minGoals = players.Min(x => x.Goals);

int numberOfPlayersBelowAverage = players.Count(x => x.Goals < averageOfPoints);
Console.WriteLine($"{numberOfPlayersBelowAverage} teljesített átlag alatt");

Console.WriteLine("Átlag felett teljesítő játékosok:\n");
Player[] playersAboveAverage = players.Where(x => x.Goals > averageOfPoints).ToArray();
PrintPlayersToConsole(playersAboveAverage);

Console.WriteLine("Legkevesebb gólt szerző játékos(ok):\n");
Player[] playerThatHasMinGoals = players.Where(x => x.Goals == minGoals).ToArray();
PrintPlayersToConsole(playerThatHasMinGoals);

Player[] GetPlayers()
{
    Player[] players = new Player[NUMBER_OF_PLAYERS];

    for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a játékos nevét: ");
        int goals = ExtendedConsole.ReadInteger("Adja meg a játékos góljainak számát: ");

        players[i] = new Player(name, goals);
    }

    return players;
}

void PrintPlayersToConsole(Player[] players)
{
    foreach (Player player in players)
    {
        Console.WriteLine($"{player.Name} : {player.Goals}");
    }
}