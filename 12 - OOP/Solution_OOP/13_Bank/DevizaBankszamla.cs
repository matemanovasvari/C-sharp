
public class DevizaBankszamla : Bankszamla, IBetet
{
    public DevizaTipus DevizaTipus { get; set; }

    public override void Fizetes()
    {
        Egyenleg -= Egyenleg * 0.000015;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {DevizaTipus}";
    }

    public void Kamtozik()
    {
        Egyenleg += Egyenleg * 0.0125;
    }

    public DevizaBankszamla(int id, Tulajdonos tulajdonos, int szamlaSzam, double egyenleg, DevizaTipus devizaTipus) : base(id, tulajdonos, szamlaSzam, egyenleg)
    {
        DevizaTipus = devizaTipus;
    }
}