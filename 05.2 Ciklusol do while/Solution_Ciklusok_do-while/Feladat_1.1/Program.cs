using System.Globalization;

int number = 0;
bool isNumber = false;

do
{
    Console.WriteLine("Adjon meg egy számot 0 - 9 közt!: ");
    string input = Console.ReadLine();
    /* az input változó értékét megpróbálja a TryParse számmá alakítani: 
     * -ha sikerül az isNumber értéke true és a number változóba eltárolódik a beírt szám értékként
     * - ha nem silerül az isNumber értéke false lesz és a number váltózó értéke nem  változik, megmarad a deklarálásko megadott értéken
     * new CultureInfo() jelentése az, hogy tizedes vessző helyett írhatunk pontot
     */
    isNumber = int.TryParse(input, new CultureInfo("US-en"), out number);
    if (!isNumber)
    {
        Console.WriteLine("Nem számot adott meg!!!!!!!!!");
    }
    else if (number < 0 || number > 9)
    {
        Console.WriteLine("Nincs a tartományban");
    }
    else
    {
        Console.WriteLine($"A beolvasott szám: {number}");
    }
} 
while(!isNumber || number < 0 || number > 9);

Console.ReadKey();