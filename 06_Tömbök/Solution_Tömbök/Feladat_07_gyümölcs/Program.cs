using Custom.Library.ConsoleExtension;

const int NUMBER_OF_FRUITS = 3;
Fruit[] fruits = GetFruits();

double sumOfAmount = fruits.Sum(x => x.Amount);

double sumOfStockValue = fruits.Sum(x => x.StockValue);

Fruit[] mostExpensiveFruit = fruits.Where(x => x.UnitPrice == (fruits.Max(x => x.UnitPrice))).ToArray();

double smallestAmountOfFruit = fruits.Min(x => x.Amount);

Fruit[] fruitsLessThan100Kgs = fruits.Where(x => x.Amount < 100).ToArray();


Console.WriteLine($"összesen {sumOfAmount} gyümölcs van készleten");

Console.WriteLine("A készletértékek:");
PrintStockValuesPerFruit(fruits);

Console.WriteLine($"A teljes készletérétk: {sumOfStockValue}");

PrintMostExpensiveFruit(mostExpensiveFruit);

Console.WriteLine($"Legkevesebb gyümölcs mennyisége: {smallestAmountOfFruit}");

PrintFruitsThatWeighLessThan100(fruitsLessThan100Kgs);

bool isAnyFruitMoreExpensiveThan1500Ft = fruits.Any(x => x.UnitPrice > 1500);
Console.WriteLine($"{(isAnyFruitMoreExpensiveThan1500Ft ? "Van" : "Nincs")} olyan gyümölcs ami drágább 1500 Forint-nál");

Fruit[] GetFruits(){
    Fruit[] fruits = new Fruit[NUMBER_OF_FRUITS];

    for (int i = 0; i < NUMBER_OF_FRUITS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a gyümölcs nevét: ");
        double amount = ExtendedConsole.ReadDouble("Adja meg, hogy hágy kg: ");
        double unitPrice = ExtendedConsole.ReadDouble("Adja meg, hogy mennyi a gyümölcs egységára: ");

        fruits[i] = new Fruit(name, amount, unitPrice);
    }
    return fruits;
}

void PrintStockValuesPerFruit(Fruit[] fruits)
{
    foreach (Fruit fruit in fruits)
    {
        Console.WriteLine($"A gyümölcs fajtája: {fruit.Name}, készlet érték: {fruit.StockValue} Ft");
    }
}

void PrintMostExpensiveFruit(Fruit[] array)
{
    foreach(Fruit fruit in array)
    {
        Console.WriteLine($"A legdrágább gyümölcs a {fruit.Name}, az ára: {fruit.UnitPrice}");
    }
}

void PrintFruitsThatWeighLessThan100(Fruit[] array)
{
    foreach (Fruit fruit in array)
    {
        Console.WriteLine($"Gyümölcs: {fruit.Name}, Mennyisége: {fruit.Amount}kg, Egységára: {fruit.UnitPrice}");
    }
}