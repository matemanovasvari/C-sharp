/*
7 - Kérjünk be egy számot és egy másikat úgy, hogy nagyobb legyen az elsőnél Számoljunk
visszafelé a nagyobbik számtól a kisebbik felé ..(A feladat kiegészíthető azzal, hogy bekérjük a
lépésközt is, ami kisebb kell legyen a két szám különbségénél
*/
using System.Globalization;
using System.Security.AccessControl;

int firstNumber = 0;
int secondNumber = 0;
bool isNumber = false;

do
{
    Console.Write("Please type in a number!: ");
    string input = Console.ReadLine();

    isNumber = int.TryParse(input, new CultureInfo("US-en"), out firstNumber);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }

} while (firstNumber == 0 || !isNumber);

do
{
    Console.Write("Please type in a number!: ");
    string input2 = Console.ReadLine();

    isNumber = int.TryParse(input2, new CultureInfo("US-en"), out secondNumber);
    if (!isNumber)
    {
        Console.WriteLine("NaN");
    }

} while ((secondNumber == 0 || firstNumber > secondNumber) || !isNumber);

for (int i = secondNumber; i > firstNumber-1; i--)
{
    Console.WriteLine(i);
}

Console.ReadKey();