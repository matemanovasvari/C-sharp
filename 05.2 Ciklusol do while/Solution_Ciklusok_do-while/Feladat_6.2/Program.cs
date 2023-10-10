/*6
Olvassunk be egy életkort 0 99 között Addig ismételjük amíg nem lesz jó a bevitel! Adjuk
meg hogy melyik korosztályba esik az illető
(
0 6 gyerek, 7 18 iskolás, 19 65 dolgozó, 65 nyugdíjas)*/
using System.Data.Common;
using System.Globalization;

int age = 0;
bool isNumber = false;

while ((age < 0 && age > 99) || !isNumber)
{
    Console.Write("Please type in a number that is a max value!: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("US-en"), out age);
    if (!isNumber)
    {
        Console.WriteLine("NaN"); 
    }
} 

string? ageGroup = age switch
{
    > 0 and <= 6 => "kid",
    >= 7 and <= 18 => "schooler",
    >= 19 and <= 65 => "worker",
    >= 65 and <= 99 => "retired",
    _ => null
};
if (ageGroup == null)
{
    Console.WriteLine("No such age group!");
}
else
{
    Console.WriteLine($"You are {ageGroup}");
}
Console.ReadKey();