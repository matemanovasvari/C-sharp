Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber >= 0)
{
    Console.Write("pozitív");
}
else
{
    Console.Write("negatív");
}

Console.ReadKey();