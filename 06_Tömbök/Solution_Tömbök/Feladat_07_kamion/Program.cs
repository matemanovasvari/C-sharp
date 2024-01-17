using Custom.Library.ConsoleExtension;
using System.Numerics;

const int NUMBER_OF_TRUCKS = 5;

Random rnd = new Random();

Truck[] trucks = GetTrucks();

PrintTrucksToConsole(trucks);

double sumOfWeights = trucks.Sum(x => x.Weight);
Console.WriteLine($"A tömegek összege: {sumOfWeights}");

double averageWeight = trucks.Average(x => x.Weight);
Console.WriteLine($"Az átlagos tömeg: {averageWeight}");

double maxWeight = trucks.Max(x => x.Weight);
Truck[] heaviestTruck = trucks.Where(x => x.Weight == maxWeight).ToArray();
PrintTrucksToConsole(heaviestTruck);

bool wasThereA10TonTruck = trucks.Any(x => x.Weight == 10);
Console.WriteLine($"{(wasThereA10TonTruck ? "Van" : "Nincs")} olyan kamion aminek a rakománya 10 tonna");

double smallestWeight = trucks.Min(t => t.Weight);
int numberOfLightestTruck = LightestTruckIndex(trucks, smallestWeight);
Console.WriteLine($"\nA legkönnyebb kamion {numberOfLightestTruck}-ként haladt át.");

Truck[] GetTrucks()
{
    Truck[] trucks = new Truck[NUMBER_OF_TRUCKS];

    for (int i = 0; i < NUMBER_OF_TRUCKS; i++)
    {
        string plate = ExtendedConsole.ReadString("Adja meg a kamion rendszámát: ");

        double weight = GenerateWeight();

        trucks[i] = new Truck(plate, weight);
    }

    return trucks;
}

double GenerateWeight()
{
    double weight = rnd.Next(3, 40);

    double addedThing = weight == 3 ? (double)rnd.Next(5, 10) / 10 : (double)rnd.Next(1, 10) / 10;
    
    weight += addedThing;

    return weight;
}

void PrintTrucksToConsole(Truck[] trucks)
{
    foreach(Truck truck in trucks)
    {
        Console.WriteLine($"A kamion rendszáma: {truck.Plate}, A kamion súlya: {truck.Weight}");
    }
}

void PrintPlatesToConsole(Truck[] trucks)
{
    foreach (Truck truck in trucks)
    {
        Console.WriteLine($"A kamion rendszáma: {truck.Plate}");
    }
}

int LightestTruckIndex(Truck[] trucks, double smallestWeight)
{
    int numberOfTruck = 0;
    for (int i = 0; i < NUMBER_OF_TRUCKS; i++)
    {
        if (trucks[i].Weight == smallestWeight)
        {
            numberOfTruck = i + 1;
            break;
        }
    }
    return numberOfTruck;
}