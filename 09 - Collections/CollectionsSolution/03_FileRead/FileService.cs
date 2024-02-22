public static class FileService
{
    #region File Read
    public static async Task<List<Player>> ReadFromFileV2Async(string fileName)
    {
        List<Player> players = new List<Player>();
        Player player = null;
        string[] data = null;

        string path = Path.Combine("source", $"{fileName}.txt");

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF8);

        foreach (string line in lines.Skip(1)) // elso sor atugrasa
        {
            data = line.Split("\t");
            player = new Player();
            player.Name = data[0];
            player.Height = int.Parse(data[1]);
            player.Position = data[2];
            player.Nationality = data[3];
            player.Team = data[4];
            player.Country = data[5];

            players.Add(player);
        }

        return players;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileV2Async(string fileName, ICollection<Player> players)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Player player in players)
        {
            data.Add($"{player.Name}\t{player.Height}\t{player.Position}\t{player.Nationality}\t{player.Team}\t{player.Country}");

            await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
        }
    }

    public static async Task WriteToFileV2Async(string fileName, ICollection<TeamAndNames> players)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (TeamAndNames player in players)
        {
            data.Add($"{player.Team}: {string.Join(", ", player.Names)}\n");
        }

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }

    public static async Task WriteToFileV2Async(string fileName, ICollection<NationalityAndAmount> players)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (NationalityAndAmount player in players)
        {
            data.Add($"{player.Nationality}: {player.Amount}\n");
        }

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }

    public static async Task WriteToFileV3Async(string fileName, ICollection<Player> players)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Player player in players)
        {
            data.Add($"{player.Name}: {player.Height}\n");
        }

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }
    #endregion
}