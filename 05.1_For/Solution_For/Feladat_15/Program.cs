/*15 – A felhasználótól kérjünk be egy intervallumot (kezdő és vég értéket), majd az
intervallumban ellenőrizzük, hogy hány olyan páratlan szám van a két szám közt mely
osztható 3-al.
*/

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
    if (i % 3 == 0 && i % 2 != 0)
    {
        divisibleByThree++;
    }
}

Console.WriteLine($"There are {divisibleByThree} odd numbers divisible by three");