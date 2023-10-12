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
bool isNumber2 = false;
double arithmeticAvegrage = 0;
double average = 0;
int divisibleByFour = 0;

while ((firstNumber % 2 != 0 || secondNumber % 2 == 0 || secondNumber < firstNumber) || !isNumber || !isNumber2)
{
    Console.WriteLine("Please type in an even number!: ");
    string input = Console.ReadLine();

    Console.WriteLine("Please type in an odd number!: ");
    string input2 = Console.ReadLine();

    isNumber = int.TryParse(input, out firstNumber);
    isNumber2 = int.TryParse(input2, out secondNumber);

    if (!isNumber || !isNumber2)
    {
        Console.WriteLine("NaN");
    }
};

int randomNumber = random.Next(firstNumber, secondNumber);

arithmeticAvegrage = firstNumber + ((secondNumber - firstNumber) / 2);

if (randomNumber > arithmeticAvegrage)
{
    Console.WriteLine($"{firstNumber} is further from {randomNumber}");
}
else
{
    Console.WriteLine($"{secondNumber} is further from {randomNumber}");
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