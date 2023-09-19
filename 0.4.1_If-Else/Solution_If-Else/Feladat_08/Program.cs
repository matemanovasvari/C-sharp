Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber % 4 == 0 && inputedNumber % 6 == 0)
{
    Console.Write($"{inputedNumber} is divisible by 4 and 6");
}
else
{
    Console.Write($"{inputedNumber} is not divisible by 4 and 6");
}

Console.ReadKey();