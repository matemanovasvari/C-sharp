namespace Models;

public class MMO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("short_description")]
    public string Short_Description { get; set; }

    [JsonPropertyName("game_url")]
    public string Game_Url { get; set; }

    [JsonPropertyName("genre")]
    public string Genre { get; set; }

    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    [JsonPropertyName("publisher")]
    public string Publisher { get; set; }

    [JsonPropertyName("developer")]
    public string Developer { get; set; }

    [JsonPropertyName("release_date")]
    public string Release_Date { get; set; }

    [JsonPropertyName("profile_url")]
    public string Profile_Url { get; set; }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Id: {this.Id}");
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Thumbnail: {this.Thumbnail}");
        sb.AppendLine($"Short description: {this.Short_Description}");
        sb.AppendLine($"Game url: {this.Game_Url}");
        sb.AppendLine($"Genre: {this.Genre}");
        sb.AppendLine($"Platform: {this.Platform}");
        sb.AppendLine($"Publisher: {this.Publisher}");
        sb.AppendLine($"Developer: {this.Developer}");
        sb.AppendLine($"Release date: {this.Release_Date}");
        sb.AppendLine($"Profile_Url: {this.Profile_Url}");

        return sb.ToString();
    }

}