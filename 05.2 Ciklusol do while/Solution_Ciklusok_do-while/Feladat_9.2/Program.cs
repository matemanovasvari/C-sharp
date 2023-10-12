﻿/*
9 -- Kérjünk be egy 3 jegyű számot és állapítsuk meg, hogy osztható e 7 el Addig ismételjük
a bekérést, amíg nem 3 jegyű a megadott szám 
*/

int number = 0;
bool isNumber = false;

while (number.ToString().Length != 3 || !isNumber)
{
    Console.WriteLine("Please type in a 3 digit number!: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number);

    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }
}

if (number % 7 == 0)
{
    Console.WriteLine("Can be divided by 7");
}
else
{
    Console.WriteLine("Cannot be divided by 7");
}