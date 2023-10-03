/*2 – Írjunk programot, amely bekéri a nevünket, és ha azt megadtuk, akkor üdvözlő szöveggel 
üdvözli a felhasználót.*/
string name = string.Empty;

do
{
    Console.WriteLine("Please state your name!: ");
    name = Console.ReadLine().Trim();
}
while (name.Length < 2);

Console.WriteLine($"Hello, {name}");

Console.ReadKey();