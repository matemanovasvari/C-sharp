int startValue = 0;
int endValue = 0;
string input = string.Empty;
bool isNumber = false;
int sumOfInterval = 0;
int numberOfNumbersInInterval = 0;
double averageOfInterval = 0;
int numberOfOdds = 0;
int numberOfNumbersThatAreEvenAndDivisibleBySeven = 0;

do
{
    Console.Write("Please type in a start value!: ");
    input = Console.ReadLine();

    isNumber = int.TryParse(input, out startValue);
}
while(!isNumber);

isNumber = false;

do
{
    Console.Write("Please type in an end value!: ");
    input = Console.ReadLine();

    isNumber = int.TryParse(input, out endValue);
}
while (!isNumber || startValue > endValue);

/*1.Feladat*/
for (int i = startValue;  i <= endValue; i++)
{
    sumOfInterval += i;
}
Console.WriteLine($"The sum of number in the interval is: {sumOfInterval}");

/*2.Feladat*/
for (int i = startValue; i <= endValue; i++)
{
    numberOfNumbersInInterval++;
    averageOfInterval = ((double)(sumOfInterval)) / numberOfNumbersInInterval;
}
Console.WriteLine($"The average of the interval is: {averageOfInterval}");

/*3.Feladat*/
for (int i = startValue; i <= endValue; i+=2)
{
    if(startValue % 2 == 0)
    {
        startValue--;
    }
    numberOfOdds++;
}
Console.WriteLine($"The numbers of odds: {numberOfOdds}");

/*4.Feladat*/
Console.WriteLine("The numbers divisible by 3 are:");
for (int i = startValue; i <= endValue; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

/*5.Feladat*/
Console.WriteLine("The numbers that are odd and  divisible by seven are:");
for (int i = startValue; i <= endValue; i++)
{
    if(i % 2 == 0 && i % 7 == 0)
    {
        Console.WriteLine(i);
    }
}