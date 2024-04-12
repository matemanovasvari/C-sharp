namespace HttpServices;

public class BeerService : BaseService
{
    public static async Task<Beer> GetByIdAsync(int id)
    {
        Beer beer = await SendGetRequestAsync<Beer>("api/beer/get", id);
        return beer;
    }

    public static async void CreateById(Beer beer)
    {
        await SendPostRequestAsync<Beer>("api/beer/create", beer);
    }
}