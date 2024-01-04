using Custom.Library.ConsoleExtension;

const int NUMBER_OF_CARS = 2;

Car[] cars = GetCars();
Car[] fastcars = cars.Where(x => x.Speed > 90).ToArray();

int sumOfFines = cars.Sum(x => x.Fine);
int numberOfCarsThatWentLegally = cars.Count(x => x.Speed <= 90);

double percentige = (numberOfCarsThatWentLegally / NUMBER_OF_CARS) * 100;

PrintFastCarsToConsole(fastcars);
Car[] GetCars()
{
    Car[] cars = new Car[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string plate = ExtendedConsole.ReadString("Adja meg az autó rendszámát: ");
        int speed = ExtendedConsole.ReadInteger("Adja meg az autó sebességét: ");
        int fine = CalculateFine(speed);

        cars[i] = new Car(plate, speed, fine);
    }
    return cars;
}

int CalculateFine(int speed)
{
    int fine = speed switch
    {
        > 110 => fine = 30000,
        > 100 => fine = 20000,
        > 90 => fine = 10000,
        _ => 0
    };

    return fine;
}

void PrintFastCarsToConsole(Car[] fastcars)
{
    foreach(Car item in fastcars)
    {
        Console.WriteLine($"A gyorsan hajtó autó rendszáma: {item.Plate}\nA gyorsan hajtó autó büntetése: {item.Speed}");
    }
}

Console.WriteLine($"Az összes kiosztott bírságok összege: {sumOfFines}");
Console.WriteLine($"A jól közlekedők százaléka: {percentige}");

int numberOfCarsThatWentWithSixty = cars.Count(x => x.Speed == 60);
if (numberOfCarsThatWentWithSixty > 0)
{
    Console.WriteLine("Volt olyan autó ami 60-nal ment");
}