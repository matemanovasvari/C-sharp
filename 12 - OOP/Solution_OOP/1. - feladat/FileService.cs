using System.Text;

public static class FileService
{
    #region File Read
    public static async Task<List<LottoPlayer>> ReadFromFileV2Async(string fileName)
    {
        List<LottoPlayer> lottoPlayers = new List<LottoPlayer>();
        LottoPlayer lottoPlayer = null;
        string[] data = null;

        string path = Path.Combine("source", $"{fileName}.txt");

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF8);

        foreach (string line in lines)
        {
            data = line.Split("\t");

            lottoPlayer = new LottoPlayer();
            lottoPlayer.Name = data[0];
            string[] guesses = data[1].Split(",");

            foreach (string item in guesses)
            {
                lottoPlayer.Guess.Add(int.Parse(item));
            }

            lottoPlayers.Add(lottoPlayer);
        }

        return lottoPlayers;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileAsync<T>(string fileName, T item)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        data.Add($"{item.ToString()}");

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }
    #endregion
}