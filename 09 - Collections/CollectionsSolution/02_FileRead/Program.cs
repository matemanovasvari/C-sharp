using System;

List<Book> books = await FileService.ReadFromFileV2Async("konyvek.txt");

books.WriteCollectionToConsole();

List<Book> ITBooks = books.Where(x => x.Topic == "informatika").ToList();

await FileService.WriteToFileV2Async("informatika", ITBooks);

List<Book> booksWrittenIn1900 = books.Where(x => x.PublishYear > 1900 && x.PublishYear < 2000).ToList();
await FileService.WriteToFileV2Async("1900", booksWrittenIn1900);

List<Book> orderedBooks = books.OrderByDescending(x => x.PageNumber).ToList();
await FileService.WriteToFileV2Async("sorbarakott", orderedBooks);

List<TopicPerTitle> topicPerTitles = books.GroupBy(x => x.Topic)
                                            .Select(x => new TopicPerTitle
                                            {
                                                Topic = x.Key,
                                                Titles = x.Select(b => b.Title.ToUpper()).ToList(),
                                            })
                                            .ToList();

await FileService.WriteToFileV2Async("kategoriak", topicPerTitles);

Console.ReadKey();