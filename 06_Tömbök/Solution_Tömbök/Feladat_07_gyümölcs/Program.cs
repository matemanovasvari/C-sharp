using Custom.Library.ConsoleExtension;

const int NUMBER_OF_FRUITS = 5;
Fruit[] fruits = GetFruits();

int SumOfAmount = fruits.Sum(x => x.Amount);
Fruit[] GetFruits(){
    Fruit[] fruits = new Fruit[NUMBER_OF_FRUITS];

    for (int i = 0; i < NUMBER_OF_FRUITS; i++)
    {
        string name = ExtendedConsole.ReadString("Adja meg a gyümölcs nevét: ");
        int amount = ExtendedConsole.ReadInteger("Adja meg, hogy hágy kb: ");
        double unitPrice = ExtendedConsole.ReadInteger("Adja meg, hogy mennyit tankolt: ");

        fruits[i] = new Fruit(name, amount, unitPrice);
    }
    return fruits;
}