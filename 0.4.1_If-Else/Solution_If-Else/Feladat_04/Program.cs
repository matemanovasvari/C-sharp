Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write($"{firstNumber} is bigger than {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.Write($"{secondNumber} is bigger than {firstNumber}");
}

Console.ReadKey();