/*Olvassunk be konzolról egy számot, majd állapítsuk meg, hogy ez a szám 0 és 9 
közt van-e, vagy 10 és 99 , vagy 100 és 999 közt.
Ha 0 és 9 közt van írjuk ki, hogy egyjegyű szám.
Ha 10 és 99 közt van írjuk ki, hogy kétegyű szám.
Ha 100 és 999 közt van írjuk ki, hogy háromegyű szám.*/
Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber >= 0 && inputedNumber <= 9)
{
    Console.Write($"{inputedNumber} egyjegyű");
}
else if (inputedNumber >= 10 && inputedNumber <= 99)
{
    Console.Write($"{inputedNumber} kétjegyű");
}
else if (inputedNumber >= 100 && inputedNumber <= 999)
{
    Console.Write($"{inputedNumber} háromjegyű");
}
else
{
    Console.Write($"{inputedNumber} se egyjegyű, se kétjegyű, se hátomjegyű");
}

Console.ReadKey();