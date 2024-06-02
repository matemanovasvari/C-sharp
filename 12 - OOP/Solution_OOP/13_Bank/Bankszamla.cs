public abstract class Bankszamla
{
    public int Id { get; set; }

    public Tulajdonos Tulajdonos { get; set; }

    public int Szamlaszam { get; set; }

    public double Egyenleg { get; set; }

    public abstract void Fizetes();

    public double EgyenlegLekerese()
    {
        return Egyenleg;
    }

    public Bankszamla()
    {
        
    }

    protected Bankszamla(int id, Tulajdonos tulajdonos, int szamlaszam, double egyenleg)
    {
        Id = id;
        Tulajdonos = tulajdonos;
        Szamlaszam = szamlaszam;
        Egyenleg = egyenleg;
    }
}