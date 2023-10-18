int start;
int end;
bool Isnumber = false;
string input = string.Empty;

do
{
    Console.Write("Please type in a starter value: ");
    input = Console.ReadLine();

    Isnumber = int.TryParse(input, out start);
}
while (!Isnumber);

Isnumber = false;

do
{
    Console.Write("Please type in an end value that's bigger than the start: ");
    input = Console.ReadLine();

    Isnumber = int.TryParse(input, out end);
}
while (!Isnumber || end < start);

if (start % 2 != 0)
{
    for (int i = start + 1; i <= end; i += 2)
    { Console.WriteLine(i); }
}