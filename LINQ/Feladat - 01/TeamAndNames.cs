using System.Collections.Generic;

public class TeamAndNames
{

    public string Club { get; set; }

    public List<string> PlayerName { get; set; }
    
    public TeamAndNames(string club, List<string> playerName)
    {
        Club = club;
        PlayerName = playerName;
    }

    public TeamAndNames()
    {
    }

    
}
