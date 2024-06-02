namespace HttpServices;

public class MMOService : BaseService
{
    public static async Task<MMO> GetByIdAsync(int id)
    {
        MMO mmo = await SendGetRequestAsync<MMO>("api/game/get", id);
        return mmo;
    }

    public static async Task<bool> DeleteAsync(int id)
    {
        bool result = await SendDeleteRequestAsync("api/game/delete", id);

        return result;
    }

    public static async Task UpdateAsync(MMO mmo)
    {
        await SendPutRequestAsync("api/game/update", mmo);
    }

    public static async Task<MMO> CreateById(MMO mmo)
    {
        return await SendPostRequestAsync<MMO>("api/game/create", mmo);
    }
}