int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int divisibleByThree = 0;

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

for (int i = start; i <= end; i++)
{
    if (i % 3 == 0)
    {
        divisibleByThree++;
    }
}

Console.WriteLine($"There are {divisibleByThree} numbers divisible by three");