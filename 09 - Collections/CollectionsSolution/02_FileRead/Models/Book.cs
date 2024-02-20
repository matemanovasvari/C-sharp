public class Book
{

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public string Title { get; set; }

    public string ISBN { get; set; }

    public string Publisher { get; set; }

    public int PublishYear { get; set; }

    public int Price { get; set; }

    public string Topic { get; set; }

    public int PageNumber { get; set; }

    public int Honorarium { get; set; }
    public Book(string firstName, string lastName, DateTime birthDate, string title, string iSBN, string publisher, int publishYear, int price, string topic, int pageNumber, int honorarium)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Title = title;
        ISBN = iSBN;
        Publisher = publisher;
        PublishYear = publishYear;
        Price = price;
        Topic = topic;
        PageNumber = pageNumber;
        Honorarium = honorarium;
    }

    public Book()
    {
    }

    public override string ToString()
    {
        return $"{this.FirstName}\t{this.LastName}\t{this.BirthDate}\t{this.Title}\t{this.ISBN}" +
                $"\t{this.Publisher}\t{this.PublishYear}\t{this.Price}\t{this.Topic}\t{this.PageNumber}\t{this.Honorarium}";
    }
}