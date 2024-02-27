using System.Numerics;

public class NationalityAndAmount
{
    public string Nationality { get; set; }

    public int Amount { get; set; }

    public override string ToString()
    {
        return $"{Nationality}: {Amount}\n";
    }
}