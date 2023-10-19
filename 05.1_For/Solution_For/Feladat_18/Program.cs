/*18 – A felhasználótól kérjünk be egy intervallumot (kezdő és vég értéket). Az első elemet
adjuk hozzá az összeghez, a másodikat vonjuk ki, a harmadikat újra adjuk hozzá az
összeghez, a negyediket vonjuk ki az összegből … és így tovább.*/

int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int sum = 0;

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
    if (i % 2 != 0)
    {
        sum += i;
    }
    else
    {
        sum -= i;
    }
}

Console.WriteLine($"{sum}");