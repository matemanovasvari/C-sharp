Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber > 0)
{
    Console.Write($"{inputedNumber} is bigger than zero");
}
else
{
    Console.Write($"{inputedNumber} is smaller than zero");
}

Console.ReadKey();