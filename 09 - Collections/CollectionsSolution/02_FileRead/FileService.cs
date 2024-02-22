public static class FileService
{
    #region File Read
    public static async Task<List<Book>> ReadFromFileV2Async(string fileName)
    {
        List<Book> books = new List<Book>();
        Book book = null;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF7);

        foreach (string line in lines)
        {
            data = line.Split("\t");

            book = new Book();
            book.FirstName = data[0];
            book.LastName = data[1];
            book.BirthDate = DateTime.Parse(data[2]);
            book.Title = data[3];
            book.ISBN = data[4];
            book.Publisher = data[5];
            book.PublishYear = int.Parse(data[6]);
            book.Price = int.Parse(data[7]);
            book.Topic = data[8];
            book.PageNumber = int.Parse(data[9]);
            book.Honorarium = int.Parse(data[10]);

            books.Add(book);
        }

        return books;
    }
    #endregion

    #region File Write
    public static async Task WriteToFileV2Async(string fileName, ICollection<Book> books)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (Book book in books)
        {
            data.Add($"{book.FirstName}\t{book.LastName}\t{book.BirthDate}\t{book.Title}\t{book.ISBN}" +
                $"\t{book.Publisher}\t{book.PublishYear}\t{book.Price}\t{book.Topic}\t{book.PageNumber}\t{book.Honorarium}");

            await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
        }
    }

    public static async Task WriteToFileV2Async(string fileName, ICollection<TopicPerTitle> books)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{fileName}.txt");
        List<string> data = new List<string>();

        foreach (TopicPerTitle book in books)
        {
            data.Add($"{book.Topic}\n");
            foreach (string x in book.Titles)
            {
                data.Add($"\t- {x}");
            }


        }
        
        await File.WriteAllLinesAsync(path, data, Encoding.UTF8);
    }
    #endregion
}