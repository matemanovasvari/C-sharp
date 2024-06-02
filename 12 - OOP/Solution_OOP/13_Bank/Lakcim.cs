public class Lakcim
{
    public int Id { get; set; }

    public string Orszag { get; set; }

    public int Iranyitoszam { get; set; }

    public string TelepulesNeve { get; set; }

    public string KozteruletNeve { get; set; }

    public int Hazszam { get; set; }

    public Lakcim()
    {
        
    }

    public Lakcim(int id, string orszag, int iranyitoszam, string telepulesNeve, string kozteruletNeve, int hazszam)
    {
        Id = id;
        Orszag = orszag;
        Iranyitoszam = iranyitoszam;
        TelepulesNeve = telepulesNeve;
        KozteruletNeve = kozteruletNeve;
        Hazszam = hazszam;
    }

    public override string ToString()
    {
        return $"{Id} - {Orszag} - {Iranyitoszam} - {TelepulesNeve} - {KozteruletNeve} - {Hazszam}";
    }
}