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


for (int i = end; i >= start; i--)
{
 Console.WriteLine(i);
}