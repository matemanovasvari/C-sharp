/*Olvassunk be két egész számot, x és y, konzolról és állapítsuk meg, hogy az y 
osztójja e az x-nek*/
Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
    Console.Write($"{firstNumber} can be divided with {secondNumber}");
}
else
{
    Console.Write($"{firstNumber} can't be divided with {secondNumber}");
}

Console.ReadKey();