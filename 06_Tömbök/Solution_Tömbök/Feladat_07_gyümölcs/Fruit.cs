public class Fruit
{
    public string Name { get; set; }
    public int Amount { get; set; }

    public double UnitPrice { get; set; }

    public Fruit()
    {

    }

    public Fruit(string name, int amount, double unitPrice)
    {
        Name = name;
        Amount = amount;
        UnitPrice = unitPrice;
    }
}