namespace MMOApp;

public static class AppState
{
    private static MMO selectedMMO;

    public static void SetMMO(MMO beer) => selectedMMO = beer;

    public static void Clear() => selectedMMO = null;

    public static MMO GetMMO() => selectedMMO;

    public static void Update(MMO mmo)
    {
        selectedMMO.Title = string.IsNullOrEmpty(mmo.Title) ? selectedMMO.Title : mmo.Title;
        selectedMMO.Thumbnail = string.IsNullOrEmpty(mmo.Thumbnail) ? selectedMMO.Thumbnail : mmo.Thumbnail;
        selectedMMO.Short_Description = string.IsNullOrEmpty(mmo.Short_Description) ? selectedMMO.Short_Description : mmo.Short_Description;
        selectedMMO.Game_Url = string.IsNullOrEmpty(mmo.Game_Url) ? selectedMMO.Game_Url : mmo.Game_Url;
        selectedMMO.Genre = string.IsNullOrEmpty(mmo.Genre) ? selectedMMO.Genre : mmo.Genre;
        selectedMMO.Platform = string.IsNullOrEmpty(mmo.Platform) ? selectedMMO.Platform : mmo.Platform;
        selectedMMO.Publisher = string.IsNullOrEmpty(mmo.Publisher) ? selectedMMO.Publisher : mmo.Publisher;
        selectedMMO.Developer = string.IsNullOrEmpty(mmo.Developer) ? selectedMMO.Developer : mmo.Developer;
        selectedMMO.Release_Date = string.IsNullOrEmpty(mmo.Release_Date) ? selectedMMO.Release_Date : mmo.Release_Date;
        selectedMMO.Profile_Url = string.IsNullOrEmpty(mmo.Profile_Url) ? selectedMMO.Profile_Url : mmo.Profile_Url;
    }

    public static int GetId() => selectedMMO.Id;
}