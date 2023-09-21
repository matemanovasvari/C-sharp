/*Ki kell számítani két ellenállás eredő értékét, attól függően, hogy azok sorosan vagy
párhuzamosan vannak bekötve. Az ellenállások értékét kérjük be a felhasználótól még a
kötések jelölése:
p vagy P: párhuzamos: (R1 + R2) / (R1 * R2)
s vagy S: soros: R1 + R2
*/
Console.Write("Please type in a number!: ");
int R1 = int.Parse(Console.ReadLine());

Console.Write("Please type in another number!: ");
int R2 = int.Parse(Console.ReadLine());

Console.Write("Please choose a type of connection from the following:\nlinear\nparalell");
string typeOf = Console.ReadLine().ToLower();

double? result = typeOf switch
{
    "p" => ((double)(R1 + R2))/(R1 * R2),
    "l" => R1 + R2,
    _ => null,
};
if (result == null)
{
    Console.WriteLine("No such type of connection!!!");
}
else
{
    Console.WriteLine($"{result}");
}

Console.ReadKey();