/*8 – A felhasználótól kérjünk be egy intervallumot (kezdő és vég értéket), majd írjuk ki
növekvő sorrendbe a páratlan számokat az intervallumból.*/

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

start = start % 2 != 0 ? start : start++;

for (int i = start; i <= end; i += 2)
{
    Console.WriteLine(i); 
}