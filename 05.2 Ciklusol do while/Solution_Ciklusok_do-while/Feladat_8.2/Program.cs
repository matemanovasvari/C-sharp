/*
8 -- Készítsünk automata menüt ahol egy szám egy üdítőt jelent A felhasználónak választania
kell üdítőt, de csak azokból amelyek a kínálatban vannak Amennyiben nem azt választjuk
nem kapunk üdítőt
*/
int drinkNumber = 0;
bool isNumber = false;

while ((drinkNumber > 5 || drinkNumber < 1) || !isNumber)
{
    Console.WriteLine("Please choose from the following drinks!:\n1 -- Pepsi\n2 -- Sprite\n3 -- Fanta\n4 -- Mirinda\n5 -- Canada Dry");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, out drinkNumber);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }

    string? drink = drinkNumber switch
    {
        1 => "Pepsi",
        2 => "Sprite",
        3 => "Fanta",
        4 => "Mirinda",
        5 => "Canada Dry",
        _ => null
    };

    Console.WriteLine($"Your drink is: {drink}");
}