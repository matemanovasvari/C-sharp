/*Konzolról kérjük be, hogy a hét hányadik napja van és írjuk ki szöveges megfelelőjét,
ellenkezőleg ki kell írni, hogy ilyen nap nincs a héten, mert az hét napból áll.*/
Console.Write("Which day is it?");
int dayOfTheWeek = int.Parse(Console.ReadLine());

string nameOfTheDay = dayOfTheWeek switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Error"
};
Console.WriteLine($"The day is: {nameOfTheDay}");

Console.ReadKey();