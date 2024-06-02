public abstract class Peksutemeny(double mennyiseg, double alapar) : IArlap
{
    public double Mennyiseg { get; set; } = mennyiseg;

    private double Alapar { get; set; } = alapar;

    public abstract void Megkostol();

    public double MennyibeKerul() => Alapar * Mennyiseg;

    public override string ToString()
    {
        return $"{Mennyiseg} db {MennyibeKerul()} Ft";
    }
}