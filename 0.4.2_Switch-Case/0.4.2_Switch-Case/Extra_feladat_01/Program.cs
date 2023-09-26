Human guy1 = new Human();

Console.WriteLine("Please type in your name!:");
guy1.Name = Console.ReadLine();

Console.WriteLine("Please type in your age!:");
guy1.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Please type in your weight");
guy1.Weight = double.Parse(Console.ReadLine());

Console.WriteLine("Please type in your bench lifting weight");
guy1.BenchWeight = double.Parse(Console.ReadLine());


Human guy2 = new Human();

Console.WriteLine("Please type in your name!:");
guy2.Name = Console.ReadLine();

Console.WriteLine("Please type in your age!:");
guy2.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Please type in your weight");
guy2.Weight = double.Parse(Console.ReadLine());

Console.WriteLine("Please type in your bench lifting weight");
guy2.BenchWeight = double.Parse(Console.ReadLine());

double power = guy1.BenchWeight / guy1.Weight;
double power2 = guy2.BenchWeight / guy2.Weight;

string printing = "";
string printing2 = "";

switch (power)
{
    case > 0.2 and < 0.4:
        printing = "begginer";
        break;
    case > 0.4 and < 0.8:
        printing = "intermediate";
        break;
    case > 0.8 and < 1:
        printing = "professional";
        break;
    case >= 1:
        printing = "GOD!";
        break;
}

switch (power2)
{
    case > 0.2 and < 0.4:
        printing2 = "begginer";
        break;
    case > 0.4 and < 0.8:
        printing2 = "intermediate";
        break;
    case > 0.8 and < 1:
        printing2 = "professional";
        break;
    case >= 1:
        printing2 = "GOD!";
        break;
}

Console.WriteLine($"{printing}");
Console.WriteLine($"{printing2}");