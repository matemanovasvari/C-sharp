public class Fruit
{
    public string Name { get; set; }
    public double Amount { get; set; }

    public double UnitPrice { get; set; }

    public double StockValue => UnitPrice * Amount;

    public Fruit()
    {

    }

    public Fruit(string name, double amount, double unitPrice)
    {
        Name = name;
        Amount = amount;
        UnitPrice = unitPrice;
    }
}