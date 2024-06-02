public class Tulajdonos
{
    public int Id { get; set; }

    public string Nev { get; set; }

    public Lakcim Lakcim { get; set; }

    public Tulajdonos()
    {
        
    }

    public Tulajdonos(int id, string nev, Lakcim lakcim)
    {
        Id = id;
        Nev = nev;
        Lakcim = lakcim;
    }

    public override string ToString()
    {
        return $"{Id} - {Nev} - {Lakcim}";
    }
}