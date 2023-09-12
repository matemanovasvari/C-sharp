using System.Globalization;

Console.Write("What is your favourite band? ");
string bandName = Console.ReadLine();

Console.Write("What is your favourite music from that band? ");
string favMusic = Console.ReadLine();

Console.Write("How long is that music? ");
double lenghtOfMusic = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

Console.WriteLine($"Az ön kedvenc együttesének {bandName} a legjobb zeneszáma {favMusic}\r\nMelynek hossza {lenghtOfMusic} perc!");

Console.ReadKey();