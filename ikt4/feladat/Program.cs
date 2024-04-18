namespace DiakTantargyKezelo;

{
    class Diak
{
    public string Nev { get; set; }
    public List<Tantargy> Tantargyak { get; set; }

    public Diak(string nev)
    {
        Nev = nev;
        Tantargyak = new List<Tantargy>();
    }
}

class Tantargy
{
    public string Megnevezes { get; set; }
    public List<int> Jegyek { get; set; }

    public Tantargy(string megnevezes)
    {
        Megnevezes = megnevezes;
        Jegyek = new List<int>();
    }
}

class Program
{
    static List<Diak> diakok = new List<Diak>();
    static string diakFile = "diakok.json";

    static void Main(string[] args)
    {
        LoadDiakok();

        bool kilep = false;
        while (!kilep)
        {
            Console.Clear();
            Console.WriteLine("1. Új diák felvétele");
            Console.WriteLine("2. Diák adatainak módosítása");
            Console.WriteLine("3. Kilépés");
            Console.Write("Válassz egy menüpontot: ");

            string valasztas = Console.ReadLine();

            switch (valasztas)
            {
                case "1":
                    UjDiakFelvetele();
                    break;
                case "2":
                    DiakAdatainakModositasa();
                    break;
                case "3":
                    kilep = true;
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }
        }
    }

    static void LoadDiakok()
    {
        if (File.Exists(diakFile))
        {
            string json = File.ReadAllText(diakFile);
            diakok = JsonConverter.DeserializeObject<List<Diak>>(json);
        }
    }

    static void SaveDiakok()
    {
        string json = JsonConverter.SerializeObject(diakok);
        File.WriteAllText(diakFile, json);
    }

    static void UjDiakFelvetele()
    {
        Console.Write("Add meg az új diák nevét: ");
        string nev = Console.ReadLine();

        diakok.Add(new Diak(nev));
        SaveDiakok();

        Console.WriteLine("Új diák sikeresen hozzáadva!");
        Console.ReadKey();
    }

    static void DiakAdatainakModositasa()
    {
        Console.WriteLine("Válassz egy diákot a módosításhoz:");
        for (int i = 0; i < diakok.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {diakok[i].Nev}");
        }

        int valasztas;
        while (!int.TryParse(Console.ReadLine(), out valasztas) || valasztas < 1 || valasztas > diakok.Count)
        {
            Console.WriteLine("Érvénytelen választás. Kérlek válassz a listából.");
        }

        Diak valasztottDiak = diakok[valasztas];

        Console.WriteLine($"Módosítás a következő diákhoz: {valasztottDiak.Nev}");
        Console.WriteLine("1. Új tantárgy felvétele");
        Console.WriteLine("2. Jegy hozzáadása tantárgyhoz");
        Console.Write("Válassz egy műveletet: ");

        string muvelet = Console.ReadLine();

        switch (muvelet)
        {
            case "1":
                Console.Write("Add meg az új tantárgy nevét: ");
                string tantargyNev = Console.ReadLine();
                valasztottDiak.Tantargyak.Add(new Tantargy(tantargyNev));
                SaveDiakok();
                Console.WriteLine("Új tantárgy sikeresen hozzáadva!");
                break;
            case "2":
                Console.WriteLine("Válassz egy tantárgyat:");
                for (int i = 0; i < valasztottDiak.Tantargyak.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {valasztottDiak.Tantargyak[i].Megnevezes}");
                }

                int tantargyIndex;
                while (!int.TryParse(Console.ReadLine(), out tantargyIndex) || tantargyIndex < 1 || tantargyIndex > valasztottDiak.Tantargyak.Count)
                {
                    Console.WriteLine("Érvénytelen választás. Kérlek válassz a listából.");
                }

                Tantargy valasztottTantargy = valasztottDiak.Tantargyak[tantargyIndex];

                Console.Write("Add meg az új jegyet: ");
                int ujJegy;
                while (!int.TryParse(Console.ReadLine(), out ujJegy) || ujJegy < 1 || ujJegy > 5)
                {
                    Console.WriteLine("Érvénytelen jegy. Kérlek adj meg egy 1 és 5 közötti értéket.");
                }

                valasztottTantargy.Jegyek.Add(ujJegy);
                SaveDiakok();
                Console.WriteLine("Új jegy sikeresen hozzáadva!");
                break;
            default:
                Console.WriteLine("Érvénytelen választás.");
                break;
        }

        Console.ReadKey();
    }
}
}
