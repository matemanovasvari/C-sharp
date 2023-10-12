/*
10 -- Kérjünk be egy max 2 jegyű, pozitív n számot:
    • Írjuk ki 0 és n közt a páros számokat
    • Adjuk össze 0 és n közt az 5 el osztható számokat
    * Számoljuk meg, hány szám osztható 0 és n közt 11 el
    • Írjuk ki azon számokat 0 és n közt amelyek 7 el osztva 3 at adnak maradékul 
*/

using System.Diagnostics.CodeAnalysis;

int number = 0;
bool isNumber = false;
int sum = 0;
int divisibleByEleven = 0;

do
{
    Console.Write("please type in a 2 digit number that is positive:! ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out number );

    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }
}
while (number.ToString().Length != 2 || !isNumber);

for (int i = 0; i < number + 1; i++)
{
    Console.WriteLine($"{i}");
}

for (int i = 0; i < number + 1; i++)
{
    if (i % 5 == 0)
    {
        sum += i;
    }

    if (i % 11 == 1)
    {
        divisibleByEleven++;
    }

    if (i % 7 == 3)
    {
        Console.WriteLine($"\n{i},");
    }
}

Console.WriteLine($"\nSum of numbers divisible by 5 is: {sum}\nNumber of numbers divisible by 11 is: {divisibleByEleven}");