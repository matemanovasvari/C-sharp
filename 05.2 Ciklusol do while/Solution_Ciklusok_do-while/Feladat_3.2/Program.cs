using System.Globalization;

Random random = new Random();
int randomNumber = random.Next(0, 10);
int guessedNumber = 0;
int guessedCount = 0;
bool isNumber = false;

Console.WriteLine($"{randomNumber}");

while ((guessedNumber != randomNumber && guessedCount <= 5) || !isNumber)
{
    Console.WriteLine("Guess the random number");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("US-en"), out guessedNumber);
    if (!isNumber)
    {
        Console.WriteLine("Not a number!!!!!!!!!");
        guessedCount--;
    }
    guessedCount++;

}

if (guessedNumber == randomNumber)
{
    Console.WriteLine($"The number of tries: {guessedCount}");
}
else
{
    Console.WriteLine("You couldn't guess the random number");
}

Console.ReadKey();