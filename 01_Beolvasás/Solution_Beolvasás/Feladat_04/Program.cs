Console.Write("Please type your name: ");
string name = Console.ReadLine();
Console.Write("Please press a button: ");
char button = Console.ReadKey().KeyChar;

Console.WriteLine($"\n{name} ön a/az {button} billentyűt nyomta meg!");

Console.ReadKey();