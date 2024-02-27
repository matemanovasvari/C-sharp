public class LottoPlayer
{
    public string Name { get; set; }

    public List<int> Guess { get; set; }

    public LottoPlayer(string name, List<int> guess)
    {
        Name = name;
        Guess = guess;
    }

    public LottoPlayer()
    {
    }

    public override string ToString()
    {
        return $"{Name} : {Guess}";
    }
}