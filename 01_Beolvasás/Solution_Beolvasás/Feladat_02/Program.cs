Console.Write("Please type your name: ");
string name = Console.ReadLine();
Console.Write("Please type your birthyear: ");
int birthYear = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} ön {birthYear}-ban született!");

Console.ReadKey();