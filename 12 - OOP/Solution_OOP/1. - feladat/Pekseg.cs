using System.Text;

namespace pekseg;

public class Pekseg
{
    public static List<IArlap> Tarolo = new List<IArlap>();

    public static async void Vasarlok(string fileName)
    {
        try
        {
            string path = Path.Combine("source", fileName);

            using StreamReader sr = new StreamReader(path);

            string[] lines = await File.ReadAllLinesAsync(path, Encoding.UTF8);
            string[] data;

            foreach (var line in lines)
            {
                data = line.Split(" ");

                string type = data[0];

                if (type == "Pogacsa")
                {
                    double mennyiseg = double.Parse(data[1]);
                    double alapar = double.Parse(data[2]);
                    Tarolo.Add(new Pogacsa(mennyiseg, alapar));
                }
                else
                {
                    bool habos = data[1] == "habos";
                    Tarolo.Add(new Kave(habos));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static async void EtelLeltar()
    {
        try
        {

            foreach (var item in Tarolo)
            {
                if (item is Pogacsa)
                {
                    await FileService.WriteToFileAsync<IArlap>("leltar.txt", item);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}