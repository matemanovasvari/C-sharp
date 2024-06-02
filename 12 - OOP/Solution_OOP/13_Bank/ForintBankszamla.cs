public class ForintBankszamla : Bankszamla, IBetet
{
    public ForintBankszamla(int id, Tulajdonos tulajdonos, int szamlaszam, double egyenleg) : base(id, tulajdonos, szamlaszam, egyenleg)
    {
    }

    public void Kamtozik()
    {
        Egyenleg += Egyenleg * 0.008;   
    }


    public override void Fizetes()
    {
        Egyenleg -= Egyenleg * 0.00001;
    }
}