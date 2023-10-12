/*
11 -- Írjunk programot amely a felhasználótól bekér egy páros majd egy tőlle nagyobb
      páratlan számot A következő lépésben generáljunk egy véletlen számot e két érték közt és
      határozzuk meg mely szám (páros vagy páratlan) van messzebb a véletlen számunktól
      * Számítsuk ki a két bekért érték közti átlagot is
      * Számoljuk meg a 4 el osztható számok számát is 
*/

Random random = new Random();
int firstNumber = 0;
int secondNumber = 0;
bool isNumber = false;
string input = string.Empty;
double arithmeticAvegrage = 0;
double average = 0;
int divisibleByFour = 0;

do
{
    Console.WriteLine("Please type in an even number!: ");
    input = Console.ReadLine();

    isNumber = int.TryParse(input,  out firstNumber);

    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }
} while (firstNumber % 2 != 0 || !isNumber);

do
{
    Console.WriteLine("Please type in an even number!: ");
    input = Console.ReadLine();

    isNumber = int.TryParse(input, out secondNumber);

    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }
} while ((firstNumber % 2 == 0 || secondNumber < firstNumber) || !isNumber);

int randomNumber = random.Next(firstNumber, secondNumber);

arithmeticAvegrage = firstNumber + ((secondNumber - firstNumber) / 2);

if (randomNumber < arithmeticAvegrage)
{
    Console.WriteLine($"{randomNumber} is further from {secondNumber}");
}
else if (randomNumber > arithmeticAvegrage)
{
    Console.WriteLine($"{randomNumber} is further from {firstNumber}");
}
else
{
    Console.WriteLine($"{randomNumber} is inbetween");
}

average = ((double)(secondNumber + firstNumber)) / 2;

for (int i = firstNumber; i < secondNumber; i++)
{
    if (i % 4 == 0)
    {
        divisibleByFour++;
    }
}

Console.WriteLine($"The average is: {average}\nThere are {divisibleByFour} numbers divisible by 4 between your inputs");