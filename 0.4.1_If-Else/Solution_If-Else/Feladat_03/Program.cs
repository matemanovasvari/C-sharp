Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber > -30 && inputedNumber < 40)
{
    Console.Write("közte van");
}

else
{
    Console.Write("nincs közte");
}

Console.ReadKey();