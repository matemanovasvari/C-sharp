int start;
int end;
bool Isnumber = false;
string input = string.Empty;
int sumOfNumbersDivisibleByFive = 0;
int sumOfNumbersDivisibleBySeven = 0;

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
    if (i % 5 == 0)
    {
        sumOfNumbersDivisibleByFive += i;
    }
    else if (i % 7 == 0)
    {
        sumOfNumbersDivisibleBySeven += i;
    }
}

if (sumOfNumbersDivisibleByFive > sumOfNumbersDivisibleBySeven)
{
    Console.WriteLine("The sum of the numbers divisible by five is the bigger");
}
else if (sumOfNumbersDivisibleByFive < sumOfNumbersDivisibleBySeven)
{
    Console.WriteLine("The sum of the numbers divisible by seven is the bigger");
}
else
{
    Console.WriteLine("The sums are equal");
}