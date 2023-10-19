/*11 – A felhasználótól kérjünk be egy intervallumot (kezdő és vég értéket), majd adjuk össze e
intervallum páros számait és írjuk ki az összege, a páratlan számok szorzatát.*/

int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int sum = 0;
int multi = 1;

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
    if (i % 2 == 0)
    {
        sum += i;
    }
    else
    {
        multi *= i;
    }
}

Console.WriteLine($"The sum is: {sum}\nThe multiplication is: {multi}");