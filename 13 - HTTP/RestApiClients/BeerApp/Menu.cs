namespace BeerApp;

public static class Menu
{
    public static async Task Main()
    {
        Console.Clear();

        int id = ExtendedConsole.ReadInteger("Adja meg a sör azonosítóját!: ");

        Beer beer = await BeerService.GetByIdAsync(id);

        if(beer is null)
        {
            Console.WriteLine("Ezzel az azonosítóval nincs sör");
            await Task.Delay(3000);

            await Main();
        }
        else
        {
            AppState.SetBeer(beer);

            await UpdateOrDelete();
        }
        
    }

    public static async Task UpdateOrDelete()
    {
        Console.Clear();

        Beer beer = AppState.GetBeer();

        beer.WriteToConsole();

        Console.WriteLine();
        Console.WriteLine("1 - Torles");
        Console.WriteLine("2 - Szerkesztes");
        int option = ExtendedConsole.ReadInteger("Válasszon műveletet: ", 1, 2);

        switch (option)
        {
            case 1:
                await DeleteAsync();
                break;
            case 2:
                await UpdateAsync();
                break;
        }
    }

    private static async Task DeleteAsync()
    {
        char option = ExtendedConsole.ReadChar("Biztos benne hogy törli (Y/N)?", ['y', 'Y', 'n', 'N']);

        if(option == 'n' || option == 'N')
        {
            Console.WriteLine("\nAz adat nem lett törölve");
            await Task.Delay(3000);
            await Main();
        }

        bool isSuccesful = await BeerService.SendDeleteRequestAsync("api/beer/delete", AppState.GetId());

        if (isSuccesful)
        {
            AppState.Clear();
        }

        Console.WriteLine($"{(isSuccesful ? "\nSikerült" : "\nNem sikerült")}");
        await Task.Delay(3000);

        await Main();
    }

    private static async Task UpdateAsync()
    {
        Console.Clear();

        Beer updateBeerData = GetUpdatedBeerData();

        await BeerService.SendPutRequestAsync("api/beer/update", updateBeerData);

        Console.WriteLine($"Sikerült a módosítás");
        await Task.Delay(3000);

        await Main();
    }

    private static Beer GetUpdatedBeerData()
    {
        Beer beer = new Beer();

        Console.Write("Nev: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        beer.Name = Console.ReadLine();

        Console.Write("Image: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        beer.Image = Console.ReadLine();

        double price = ExtendedConsole.ReadDouble("Ar: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        beer.Price = $"${Math.Abs(price)}";

        AppState.Update(beer);

        return AppState.GetBeer();
    }
}
