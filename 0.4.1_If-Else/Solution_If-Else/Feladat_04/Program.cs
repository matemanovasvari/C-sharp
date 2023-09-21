Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write($"{firstNumber}");
}
else
{
    Console.Write($"{secondNumber}");
}

Console.ReadKey();