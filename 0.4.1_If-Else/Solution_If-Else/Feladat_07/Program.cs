Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber % 5 == 0)
{
    Console.Write($"{inputedNumber} is divisible by five");
}
else
{
    Console.Write($"{inputedNumber} is not divisible by five");
}

Console.ReadKey();