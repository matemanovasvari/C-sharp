using Custom.Library.ConsoleExtension;
using System.Numerics;

const int NUMBER_OF_TRUCKS = 5;

Random rnd = new Random();

Truck[] trucks = GetTrucks();

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

}