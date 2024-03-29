﻿public static class FileService
{
    #region File Read
    public static async Task<List<Player>> ReadFromFileV2Async(string fileName)
    {
        List<Player> players = new List<Player>();
        Player player = null;
        string[] data = null;

        string path = Path.Combine("source", $"{fileName}.txt");

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF8);

        foreach (string line in lines) // elso sor atugrasa
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
    public static async Task WriteToFileAsync<T>(string fileName, ICollection<T> collection) where T : class
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (T item in collection)
        {
            data.Add($"{item.ToString()}");
        }

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }
    #endregion
}