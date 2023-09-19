Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber % secondNumber == 0 && firstNumber % thirdNumber == 0)
{
    Console.Write($"{firstNumber} is divisible by both {secondNumber} and {thirdNumber}");
}

else if (firstNumber % secondNumber == 0)
{
    Console.Write($"{firstNumber} is divisible by {secondNumber} but not by {thirdNumber}");
}

else if (firstNumber % thirdNumber == 0)
{
    Console.Write($"{firstNumber} is divisible by {thirdNumber} but not by {secondNumber}");
}
else
{
    Console.Write($"{firstNumber} is divisible by neither");
}

Console.ReadKey();