Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write($"{secondNumber}, {firstNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.Write($"{firstNumber}, {secondNumber}");
}

Console.ReadKey();