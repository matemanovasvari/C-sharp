using Custom.Library.ConsoleExtension;

const int NUMBER_OF_MUSICS = 3;
Random rnd = new Random();

Music[] musics = GetMusics();

double lenghtOfDisc = musics.Sum(x => x.Lenght) / 60;
Console.WriteLine($"A lemez hossza: {lenghtOfDisc:F2} perc");

double averageLenght = musics.Average(x => x.Lenght);
Console.WriteLine($"A lemezen lévő zeneszámok hosszának átlaga: {averageLenght}");

int minLenght = musics.Min(x => x.Lenght);
Music[] shortestMusic = musics.Where(x => x.Lenght == minLenght).ToArray();
Console.WriteLine("A legrövidebb zene: ");
PrintTitleToConsole(shortestMusic);

bool songLongerThenFourMins = musics.Any(x => x.LenghtInMinutes > 4);
Console.WriteLine($"{(songLongerThenFourMins ? "Van" : "Nincs")} olyan zene ami 4 percnél hosszabb.");

int maxLenght = musics.Max(x => x.Lenght);
int serialNumberOfLongestMusic = GetIndex(musics, maxLenght);
Console.WriteLine($"A leghosszabb zeneszám a {serialNumberOfLongestMusic}-ik");

Music?[] musicsWithSameLenght = GetSameLenghtSongs(musics);
Console.WriteLine($"\n2 egyenlő hosszúságú zene: {(musicsWithSameLenght != null ? "Van ugyanolyan hosszuságú zene" : "Nincs ugyanolyan hosszuságú zene")} ");
PrintMusicsToConsole(musicsWithSameLenght);

Music[] GetMusics()
{
    Music[] musics = new Music[NUMBER_OF_MUSICS];

    for(int i = 0; i < NUMBER_OF_MUSICS; i++)
    {
        string title = ExtendedConsole.ReadString("Kérem adja meg a lemez címét: ");
        int serialNumber = i + 1;
        int lenght = rnd.Next(20, 501);
        musics[i] = new Music(serialNumber, title, lenght);
    };

    return musics;
}

void PrintTitleToConsole(Music[] musics)
{
    foreach(Music music in musics)
    {
        Console.WriteLine(music.Title);
    }
}

void PrintMusicsToConsole(Music[] musics)
{
    foreach(Music music in musics)
    {
        Console.WriteLine(music);
    };
}

int GetIndex(Music[] musics, int lenght)
{
    int index = 0;

    for (int i = 0; i < NUMBER_OF_MUSICS; i++)
    {
        if (musics[i].Lenght == lenght)
        {
            index = i+1;
            break;
        };
    };

    return index;
}

Music?[] GetSameLenghtSongs(Music[] musics)
{
    Music?[] result = null;

    for (int i = 0; i < NUMBER_OF_MUSICS; i++)
    {
        for (int j = 0; j < NUMBER_OF_MUSICS; j++)
        {
            if (musics[i].Lenght == musics[j].Lenght && i != j)
            {
                result = new Music[] {musics[i], musics[j]};

                break;
            }
        }
    }

    return result;
};