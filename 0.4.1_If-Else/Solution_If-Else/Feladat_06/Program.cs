Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.Write($"{firstNumber},");
    if (secondNumber > thirdNumber)
    {
        Console.Write($"{secondNumber}, {thirdNumber}");
    }
    else
    {
        Console.Write($"{thirdNumber}, {secondNumber}");
    }
}

else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.Write($"{secondNumber},");
    if (firstNumber > thirdNumber)
    {
        Console.Write($"{firstNumber}, {thirdNumber}");
    }
    else
    {
        Console.Write($"{thirdNumber}, {firstNumber}");
    }
}

else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.Write($"{thirdNumber},");
    if (firstNumber > secondNumber)
    {
        Console.Write($"{firstNumber}, {secondNumber}");
    }
    else
    {
        Console.Write($"{secondNumber}, {firstNumber}");
    }
}

Console.ReadKey();