using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public static async Task<List<Worker>> ReadFromFileV1Async(string fileName)
{
    List<Worker> workers = new List<Worker>();
    Worker worker = null;
    string line = string.Empty;
    string[] data = null;

    string path = Path.Combine("Source", fileName);

    using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
    using StreamReader sr = new StreamReader(fs, Encoding.UTF8);

    while (!sr.EndOfStream)
    {
        workers = new DanceTypeAndCoupleNames();

        worker.Name = await sr.ReadLineAsync();
        worker.ProjectName = await sr ReadLineAsync();
        string workHoursRow = await sr ReadLineAsync();

        workHoursRow.Split(",")

        worker.WorkHours = 

        workers.Add(worker);
    }

    return workers;
}

