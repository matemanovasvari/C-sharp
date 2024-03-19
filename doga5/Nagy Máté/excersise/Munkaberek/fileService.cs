using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class FileService
{
    public static async Task<List<Worker>> ReadFromFileAsync(string fileName)
    {
        List<Worker> workers = new List<Worker>();
        Worker worker = null;
        List<int> workHours = new List<int>();
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("Source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

        while (!sr.EndOfStream)
        {

            worker.Name = await sr.ReadLineAsync();
            worker.ProjectName = await sr.ReadLineAsync();
            string workHoursRow = await sr.ReadLineAsync();

            List<string> stringList= workHoursRow.Split(",").ToList();
            List<int> workHoursList = new List<int>();

            for (int i = 0; i < stringList.Count; i++)
            {
                workHoursList.Add(int.Parse(stringList[i]));
            }

            worker.WorkHours = workHoursList.Sum();

            workers.Add(worker);
        }

        return workers;
    }

    public static async Task WriteToFileAsync<T>(string fileName, ICollection<T> collection)
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
}