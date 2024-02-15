public static class FileService
{
    #region File Read
    public static async Task<List<Student>> ReadFromFileV1Async(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF7);

        await sr.ReadLineAsync();//kiolvassa a fejlecet, csak nem csinálunk vele semmit

        while (!sr.EndOfStream)
        {
            line = await sr.ReadLineAsync();
            data = line.Split('\t');

            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileV2Async(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF7);

        foreach (string line in lines.Skip(1)) // elso sor atugrasa
        {
            data = line.Split("\t");

            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileV3Async(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;
        bool isNumber = false;

        string path = Path.Combine("source", fileName);

        IAsyncEnumerable<string> lines = File.ReadLinesAsync(path, Encoding.UTF7);

        await foreach (string line in lines)
        {
            data = line.Split("\t");


            isNumber = double.TryParse(data[1], out double average);

            if (!isNumber)
            {
                continue;
            }
            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }

    public static async Task<List<Student>> ReadFromFileV4Async(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        string text = await File.ReadAllTextAsync(path, Encoding.UTF7);

        string[] lines = text.Split("\n");

        foreach (string line in lines.Skip(1)) //elso sor atlepese
        {
            data = line.Split("\t");

            student = new Student();
            student.Name = data[0];
            student.Average = double.Parse(data[1]);

            students.Add(student);
        }

        return students;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileAsync(string fileName, ICollection<Student> students)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (Student student in students)
        {
            await sw.WriteLineAsync($"{student.Name}\t{student.Average}");
        }
    }

    public static async Task WriteToFileV2Async(string fileName, ICollection<Student> students)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Student student in students)
        {
            data.Add($"{student.Name}\t{student.Average}");

            await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
        }
    }

    public static async Task WriteToFileV3Async(string fileName, ICollection<Student> students)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");

        StringBuilder contents = new StringBuilder();

        foreach (Student student in students)
        {
            contents.AppendLine($"{student.Name}\t{student.Average}");
        }

        await File.WriteAllTextAsync(path, contents.ToString(), Encoding.UTF8);
    }
    #endregion
}