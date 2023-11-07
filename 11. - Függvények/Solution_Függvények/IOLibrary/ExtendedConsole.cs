using System.Globalization;

namespace IOLibrary;

public static class ExtendedConsole
{
    public static int ReadInteger()
    {
        bool isNumber = false;
        int number = 0;

        do
        {
            string input = Console.ReadLine();
            isNumber = int.TryParse(input, out number);
        }
        while (!isNumber);
        
        return number;
    }

    public static double ReadDouble()
    {
        bool isNumber = false;
        double number = 0;

        do
        {
            string input = Console.ReadLine();
            isNumber = double.TryParse(input, new CultureInfo("en-US"), out number);
        }
        while (!isNumber);

        return number;
    }
}
