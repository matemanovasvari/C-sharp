/*Kérjük be a hónap szöveges és írjuk ki a hónap számbeli megfelelőjét.*/
Console.Write("Which month is it?");
string month = Console.ReadLine().ToLower();
int monthIndex = month switch
{
    "january" => 1,
    "february" => 2,
    "march" => 3,
    "april" => 4,
    "may" => 5,
    "june" => 6,
    "july" => 7,
    "august" => 8,
    "september" => 9,
    "october" => 10,
    "november" => 11,
    "december" => 12,
    _ => 0
};
    Console.WriteLine($"The month is: {monthIndex}");

Console.ReadKey();