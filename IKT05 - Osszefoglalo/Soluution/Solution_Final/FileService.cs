
using System.Collections.Generic;

namespace FileServices;

public static class FileService
{
    public static async Task<List<T>> ReadFromFileAsync<T>(string fileName)
    {
        string path = Path.Combine("message_data", $"{fileName}.json");
        List<T>? result = new List<T>();

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, 128);

        result = await JsonSerializer.DeserializeAsync<List<T>>(fs);
        return result;
    }

    public static async Task WriteToFileAsync<T>(List<T> list, string fileName)
    {
        string path = Path.Combine("reports", $"{fileName}.json");
        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        await JsonSerializer.SerializeAsync(fs, list);
    }

    public static async Task WriteToTxtAsync<T>(ICollection<T> collection, string fileName)
    {
            Directory.CreateDirectory("log");
            string path = Path.Combine("output", $"{fileName}.txt");

            using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
            using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (var item in collection)
            {
                await sw.WriteLineAsync($"{item}");
            }
    }
}
