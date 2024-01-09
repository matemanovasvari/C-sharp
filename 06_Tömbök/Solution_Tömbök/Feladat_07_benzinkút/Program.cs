using Custom.Library.ConsoleExtension;

const int NUMBER_OF_CARS = 5;

Car[] cars = GetCars();

Car[] carsThatTankedMoreThen40Liters = cars.Where(x => x.GasAmount >= 40).ToArray();

double sumOfLitersTanked = cars.Sum(x => x.GasAmount);

double maxAmountTanked = cars.Max(x => x.GasAmount);
Car[] carsThatTankedMaxAmount = cars.Where(x => x.GasAmount == maxAmountTanked).ToArray();

double minAmountTanked = cars.Min(x => x.GasAmount);
Car[] carsThatTankedMinAmount = cars.Where(x => x.GasAmount == maxAmountTanked).ToArray();

int numberOfCarsThatTankedLessThen30Liters = cars.Count(x => x.GasAmount < 30);


PrintArrayToConsole(carsThatTankedMoreThen40Liters);

Console.WriteLine($"Összesen tankolt mennyiség: {sumOfLitersTanked}");

PrintArrayToConsole(carsThatTankedMaxAmount);

PrintArrayToConsole(carsThatTankedMinAmount);

Console.WriteLine($"30 liter alatt tankoló autók száma: {numberOfCarsThatTankedLessThen30Liters}");

bool isAnyCarThatWentWithSixty = cars.Any(x => x.GasAmount == 50);

Console.WriteLine($"{(isAnyCarThatWentWithSixty ? "Van" : "Nincs")} olyan autó ami 50 litert tankolt");

Car[] GetCars()
{
    Car[] cars = new Car[NUMBER_OF_CARS];

    for (int i = 0; i < NUMBER_OF_CARS; i++)
    {
        string plate = ExtendedConsole.ReadString("Adja meg az autó rendszámát: ");
        double gasAmount = ExtendedConsole.ReadInteger("Adja meg, hogy mennyit tankolt: ");

        cars[i] = new Car(plate, gasAmount);
    }
    return cars;
}

void PrintArrayToConsole(Car[] cars)
{
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"[{i + 1}] = {cars[i]}");
    }
}

