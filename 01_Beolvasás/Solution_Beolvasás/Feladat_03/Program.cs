using System.Globalization;

Console.Write("Please type your name: ");
string name = Console.ReadLine();

Console.Write("Please type your height in meters: ");
double heightInMeters = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));

Console.WriteLine($"{name} az ön magassága {heightInMeters}m", new CultureInfo("en-US"));

Console.ReadKey();