public class Kave : IArlap
{
    private bool habosE { get; set; }

    private const int CSESZEKAVE = 180;

    public Kave(bool habosE)
    {
        this.habosE = habosE;
    }

    public double MennyibeKerul()
    {
        if(habosE)
        {
            return CSESZEKAVE * 1.5;
        }
        else
        {
            return CSESZEKAVE;
        }
    }

    public override string ToString()
    {
        return $"Habos/Nem habos kave - {MennyibeKerul()} Ft";
    }
}