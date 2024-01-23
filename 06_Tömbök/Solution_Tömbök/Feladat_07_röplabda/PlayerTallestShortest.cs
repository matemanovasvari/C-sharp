public class PlayerTallestShortest
{
    public Player ShortestPlayer { get; set; }
    public Player TallestPlayer { get; set; }

    public double HeightDifference => TallestPlayer.Height - ShortestPlayer.Height;

    public PlayerTallestShortest(Player shortestPlayer, Player tallestPlayer)
    {
        ShortestPlayer = shortestPlayer;
        TallestPlayer = tallestPlayer;
    }

    public PlayerTallestShortest()
    {
    }

    public override string ToString()
    {
        return $"A legmagasabb játékos: {TallestPlayer.Name} - {TallestPlayer.Height}" +
            $"A legalacsonyabb játékos: {ShortestPlayer.Name} - {ShortestPlayer.Height}" +
            $"A magasság különbség: {HeightDifference}cm";
    }
}