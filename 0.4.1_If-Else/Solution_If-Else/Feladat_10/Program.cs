/*Olvassunk be egy egész számot. Ha a szám osztható 2-vel, írjuk ki hogy „BIZ”, ha 
osztható 3-al, írjuk ki hogy „BAZ” és ha osztható 2-vel és 3-al is akkor írjuk ki, hogy 
„ZIZI”.*/
Console.Write("Please type in a number!: ");
int inputedNumber = int.Parse(Console.ReadLine());

if (inputedNumber % 2 == 0 && inputedNumber % 3 == 0)
{
    Console.Write($"ZIZI");
}
else if (inputedNumber % 2 == 0)
{
    Console.Write($"BIZ");
}
else
{
    Console.Write("BAZ");
}

Console.ReadKey();