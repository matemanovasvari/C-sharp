public static class FileService
{
    #region File Read
    public static async Task<List<Person>> ReadFromFileV2Async(string fileName)
    {
        List<Person> people = new List<Person>();
        Person person = null;
        string[] data = null;

        string path = Path.Combine("source", $"{fileName}.csv");

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF8);

        foreach (string line in lines.Skip(1))
        {
            data = line.Split(";");

            person = new Person();
            person.Name = data[0];
            person.First = DateTime.Parse(data[1]);
            person.Last = DateTime.Parse(data[2]);
            person.Weight = int.Parse(data[3]);
            person.Height = int.Parse(data[4]);

            people.Add(person);
        }

        return people;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileAsync<T>(string fileName, ICollection<T> collection)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.csv");
        List<string> data = new List<string>();

        foreach (T item in collection)
        {
            data.Add($"{item.ToString()}");
        }

        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }
    #endregion
}