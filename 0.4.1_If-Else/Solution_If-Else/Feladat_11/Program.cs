/*Olvassunk be egy számot, majd e számról állapítsuk meg, hogy páros/páratlan, 
pozitív/negatív és osztható-e öttel.*/
Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber % 2 == 0)
{
    Console.Write($"{inputedNumber} páros, ");
}
else
{
    Console.Write($"{inputedNumber} páratlan,");
}


if (inputedNumber > 0)
{
    Console.Write("pozitív, ");
}
else
{
    Console.Write("negatív, ");
}

if (inputedNumber % 5 == 0)
{
    Console.Write("és osztható 5-tel");
}

else
{
    Console.Write("és nem osztható 5-tel");
}

Console.ReadKey();