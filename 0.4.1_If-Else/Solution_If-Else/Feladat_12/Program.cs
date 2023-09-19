/*Olvassunk be konzolról egy számot, majd állapítsuk meg, hogy ez a szám 10 és 20 
közt van-e, vagy -10 és -20 közt.*/
Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber > 10 && inputedNumber < 20)
{
    Console.Write($"{inputedNumber} is between 10 and 20, ");
}
else if (inputedNumber < -10 && inputedNumber > -20)
{
    Console.Write($"{inputedNumber} is between -10 and -20");
}
else
{
    Console.Write($"{inputedNumber} is between neither");
}

Console.ReadKey();