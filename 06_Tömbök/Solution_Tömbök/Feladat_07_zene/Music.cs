public class Music
{
    public int SerisalNumber {  get; set; }

    public string Title { get; set; }

    public int Lenght { get; set; }

    public int LenghtInMinutes => (int)Math.Floor((double)Lenght / 60);

    public int SecondsLeft => Lenght - LenghtInMinutes * 60;

    public Music(int serisalNumber, string title, int lenght)
        {
            SerisalNumber = serisalNumber;
            Title = title;
            Lenght = lenght;
        }

    public Music()
    {
    }

    public override string ToString()
    {
        return $"{SerisalNumber} - {Title} ({LenghtInMinutes}:{SecondsLeft})";
    }
};
