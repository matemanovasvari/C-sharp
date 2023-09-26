/*6 – A felhasználótól kérjük be a téglalap hosszát és szélességét. Egy menüből a
következőket tudja a felhasználó kiválasztani:
t – terület
k - kerület
a - átló*/
Console.Write("Please type in a number!: ");
int lenght = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int width = int.Parse(Console.ReadLine());

Console.Write("Please choose a type of calculation from the following:\nt - terület\nk - kerület\na - átló");
string calculation = Console.ReadLine().ToLower();

double? result = calculation switch
{
    "t" => lenght * width,
    "k" => 2 * (lenght + width),
    "a" => Math.Sqrt(Math.Pow(width, 2)+Math.Pow(lenght, 2)),
    _ => null,
};
if (result == null)
{
    Console.WriteLine("No such type of calculation!!!");
}
else
{
    Console.WriteLine($"{result}");
}

Console.ReadKey();