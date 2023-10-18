int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int sumOfEven = 0;
int sumOfOdd = 0;
int numberOfEvens = 0;
int numberOfOdds = 0;
double oddAverage = 0;
double evenAverage = 0;

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
        sumOfEven += i;
        numberOfEvens++;
    }
    else
    {
        sumOfOdd += i;
        numberOfOdds++;
    }
}
evenAverage = ((double)(sumOfEven)) / (numberOfEvens);
oddAverage = ((double)(sumOfOdd)) / (numberOfOdds);

Console.WriteLine($"Az átlagok {evenAverage} -- {oddAverage}");