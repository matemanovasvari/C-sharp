
public static class FileService
{
    public static async Task<List<T>> ReadFromFileAsync<T>(string fileName)
    {
        string path = Path.Combine("source", $"{fileName}.json");
        List<T>? result = new List<T>();

        using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

        result = await JsonSerializer.DeserializeAsync<List<T>>(fs);
        return result;
    }

    public static async Task WriteToFileAsync<T>(List<T> list, string fileName)
    {
        string path = Path.Combine("source", $"{fileName}.json");
        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
        await JsonSerializer.SerializeAsync(fs, list);
    }
}