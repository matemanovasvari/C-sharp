/*
5 - Írjunk programot, amelyben a felhasználó megad egy határértéket (min 100 majd a
felhasználótól addig kér be számokat, még azok összege nem haladja meg a határértéket
Minden bekérés után jelezni a felhasználónak a jelenlegi összeget Ha az összeg eléri a
hatarerteket akkor kiírni, hány lépésben érte el a felhasználó a hatarerteket
*/
using System.Globalization;

int maxValue = 0;
int number = 0;
int sum = 0;
bool isNumber = false;
int numberOfInputs = 0;

do
{
    Console.Write("Please type in a number that is a max value!: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("US-en"), out maxValue);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }
} while (maxValue == 0 || !isNumber);

do
{
    Console.Write("Please type in a number!: ");
    string input2 = Console.ReadLine();

    isNumber = int.TryParse(input2, new CultureInfo("US-en"), out number);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
        numberOfInputs--;
    }

    numberOfInputs++;

    sum = sum + number;

    Console.WriteLine($"The sum is: {sum}");

} while (sum < maxValue || !isNumber);

Console.WriteLine($"You've inputed {numberOfInputs} times");

Console.ReadKey();