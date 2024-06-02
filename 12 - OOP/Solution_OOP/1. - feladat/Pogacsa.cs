public class Pogacsa(double mennyiseg, double alapar) : Peksutemeny(mennyiseg, alapar)
{
    public double Mennyiseg {  get; set; }

    public double Alapar {  get; set; }
    public override void Megkostol()
    {
        Mennyiseg = Mennyiseg / 2;
    }

    public override string ToString()
    {
        return $"Pogacsa {Mennyiseg} db - {MennyibeKerul()} Ft";
    }
}