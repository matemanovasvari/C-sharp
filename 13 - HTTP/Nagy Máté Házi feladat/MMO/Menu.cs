namespace MMOApp;

public static class Menu
{
    public static async Task Main()
    {
        Console.Clear();

        await CreateOrModify();
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

        bool isSuccesful = await MMOService.DeleteAsync(AppState.GetId());

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

        MMO updateMMOData = GetUpdatedMMOData();

        await MMOService.UpdateAsync(updateMMOData);

        Console.WriteLine($"Sikerült a módosítás");
        await Task.Delay(3000);

        await Main();
    }

    private static async Task CreateAsync()
    {
        Console.Clear();

        MMO mmo = GetCreatedMMOData();
        mmo = await MMOService.CreateById(mmo);

        if (mmo.Id > 0)
        {
            Console.WriteLine($"Sikerült a létrehozás");
            await Task.Delay(3000);
            await Main();
        }
        else
        {
            Console.WriteLine($"Nem sikerült a létrehozás");
            await Task.Delay(3000);
            await Main();
        }
    }

    private static MMO GetUpdatedMMOData()
    {
        MMO mmo = new MMO();

        Console.Write("Title: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Title = Console.ReadLine();

        Console.Write("Thumbnail: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Thumbnail = Console.ReadLine();

        Console.Write("Short description: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Short_Description = Console.ReadLine();

        Console.Write("Game url: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Game_Url = Console.ReadLine();

        Console.Write("Genre: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Genre = Console.ReadLine();

        Console.Write("Platform: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Platform = Console.ReadLine();

        Console.Write("Publisher: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Publisher = Console.ReadLine();

        Console.Write("Developer: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Developer = Console.ReadLine();

        Console.Write("Release date: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Release_Date = Console.ReadLine();

        Console.Write("Profile url: (Ha nem szeretné megváltoztatni akkor nyomjon enter gombot)");
        mmo.Profile_Url = Console.ReadLine();

        AppState.Update(mmo);

        return AppState.GetMMO();
    }

    public static MMO GetCreatedMMOData()
    {
        MMO mmo = new MMO();

        mmo.Title = ExtendedConsole.ReadString("Title: ");

        mmo.Thumbnail = ExtendedConsole.ReadString("Thumbnail: ");

        mmo.Short_Description = ExtendedConsole.ReadString("Short description: ");

        mmo.Game_Url = ExtendedConsole.ReadString("Game url: ");

        mmo.Genre = ExtendedConsole.ReadString("Genre: ");

        mmo.Platform = ExtendedConsole.ReadString("Platform: ");

        mmo.Publisher = ExtendedConsole.ReadString("Publisher: ");

        mmo.Developer = ExtendedConsole.ReadString("Developer: ");

        mmo.Release_Date = ExtendedConsole.ReadString("Release date: ");

        mmo.Profile_Url = ExtendedConsole.ReadString("Profile url: ");

        return mmo;
    }

    public static async Task CreateOrModify()
    {
        Console.Clear();

        Console.WriteLine("1 - Create");
        Console.WriteLine("2 - Modify");
        int option = ExtendedConsole.ReadInteger("Válasszon műveletet: ", 1, 2);

        switch (option)
        {
            case 1:
                await CreateAsync();
                break;
            case 2:
                await ModifyAsync();
                break;
        }
    }

    public static async Task ModifyAsync()
    {
        Console.Clear();

        int id = ExtendedConsole.ReadInteger("Adja meg a játék azonosítóját!: ");

        MMO mmo = await MMOService.GetByIdAsync(id);
        AppState.SetMMO(mmo);
        mmo.WriteToConsole();

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
}
