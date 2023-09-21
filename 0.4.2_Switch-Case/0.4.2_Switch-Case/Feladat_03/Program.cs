/*Kérjük be a hónap szöveges és írjuk ki a hónap számbeli megfelelőjét.*/
Console.Write("Which drink do you want?\n1 -- Coca Cola\n2 -- Pepsi\n3 -- Fanta\n4 -- Sprite\n");
int drink = int.Parse(Console.ReadLine());

string choosenDrink = drink switch
{
    1 => "Coca Cola",
    2 => "Pepsi",
    3 => "Fanta",
    4 => "Sprite",
    _ => "No such drink"
};
Console.WriteLine(choosenDrink);

Console.ReadKey();