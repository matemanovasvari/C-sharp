public class Person
{

    public string Name { get; set; }

    public DateTime First { get; set; }

    public DateTime Last { get; set; }

    public int Weight { get; set; }

    public int Height { get; set; }

    public double HeightInCm => (double)Height * 2.54;


    public Person()
    {
    }

    public Person(string name, DateTime first, DateTime last, int weight, int height)
    {
        Name = name;
        First = first;
        Last = last;
        Weight = weight;
        Height = height;
    }

    public override string ToString()
    {
        return $"{Name};{First};{Last};{Weight};{Height}";
    }
}