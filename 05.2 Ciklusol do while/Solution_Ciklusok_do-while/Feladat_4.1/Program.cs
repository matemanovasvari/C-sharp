/*4 – Írjunk programot, amely a felhasználótól addig kér be számokat, még azok összege
meghaladja a 100-at. Minden bekérés után jelezni a felhasználónak a jelenlegi összeget és a
hányadik bevitelnél tart.*/
using System.Globalization;

int number = 0;
int sum = 0;
bool isNumber = false;
int numberOfInputs = 0;

do
{
    Console.Write("Please type in a number!: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("US-en"), out number);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
        numberOfInputs--;
    }
    numberOfInputs++;

    sum += number;

    Console.WriteLine($"The sum is: {sum}, You've inputed {numberOfInputs} times");

} while (sum < 100);

Console.ReadKey();