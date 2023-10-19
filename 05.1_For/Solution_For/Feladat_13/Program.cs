/*13 – A felhasználótól kérjünk be egy intervallumot (kezdő és vég értéket), majd
intervallumban ellenőrizzük, hogy a páros vagy páratlan számok összege e a nagyobb.*/

int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int sumOfEvenNumbers = 0;
int sumOfOddNumbers = 0;

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
        sumOfEvenNumbers += i;
    }
    else 
    { 
        sumOfOddNumbers += i; 
    }
}

if (sumOfEvenNumbers > sumOfOddNumbers)
{
    Console.WriteLine("The sum of the even numbers is the bigger");
}
else if (sumOfEvenNumbers < sumOfOddNumbers)
{
    Console.WriteLine("The sum of the odd numbers is the bigger");
}
else
{
    Console.WriteLine("The sums are equal");
}