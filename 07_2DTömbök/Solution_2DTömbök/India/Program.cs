using Custom.Library.ConsoleExtension;

const int NUMBER_OF_ROWS = 7;
const int NUMBER_OF_COLUMNS = 3;
Random rnd = new Random();

double[,] dataOfWeathers = GetMatrix();

Console.WriteLine("Írjuk ki a képernyőre a mért adatokat.  Minden egyes számra 4 karakter mezőt foglaljunk le!");
PrintMatrixToConsole(dataOfWeathers);

Console.WriteLine("A leesett napi átlag csapadékot növekvő sorrendje");
double[] dailyWeatherAverageInAscendingOrder = DailyWeatherAverage(dataOfWeathers);
Array.Sort(dailyWeatherAverageInAscendingOrder);
WriteArray(dailyWeatherAverageInAscendingOrder);

Console.WriteLine("Melyik nap esett a legtöbb csapadék");
string dayWithLargestRain = GetDayWithLargestAmountOfRain(dataOfWeathers);
Console.WriteLine(dayWithLargestRain);

Console.WriteLine("Melyik nap esett a legkevesebb csapadék");
string dayWithSmallestRain = GetDayWithSmallestAmountOfRain(dataOfWeathers);
Console.WriteLine(dayWithSmallestRain);

Console.WriteLine("Melyik nap reggelére esett a legtöbb csapadék");
string dayWithLargestMorningRain = GetDayWithLargestAmountOfMorningRain(dataOfWeathers);
Console.WriteLine(dayWithLargestMorningRain);

Console.WriteLine("Melyik nap esett a legtöbb csapadék reggel 6 és este 22 óraközt");
string dayWithLargestRainFrom6To22 = GetDayWithLargestAmountOfRainFrom6To22(dataOfWeathers);
Console.WriteLine(dayWithLargestRainFrom6To22);


double[,] GetMatrix()
{
    double[,] matrix = new double[NUMBER_OF_ROWS, NUMBER_OF_COLUMNS];
    double amountOfRain = 0;
    int decimalPart = 0;

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            decimalPart = rnd.Next(10, 100);
            amountOfRain = rnd.Next(0, 5) + (double)decimalPart / 100;
            matrix[i, j] = Math.Round(amountOfRain, 2);
        }
    }

    return matrix;
}

void PrintMatrixToConsole(double[,] matrix)
{
    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            Console.Write($"[{i},{j}] = {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
};

double[] DailyWeatherAverage(double[,] matrix)
{
    double[] dailyWeatherAverages = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            dailyWeatherAverages[i] = Math.Round((matrix[i, 0] + matrix[i, 1] + matrix[i, 2]) / 3, 2);
        }


    }

    return dailyWeatherAverages;
}

void WriteArray(double[] array)
{
    foreach (double i in array)
    {
        Console.WriteLine(i);
    }
}

string GetDayWithLargestAmountOfRain(double[,] data)
{
    string day = string.Empty;
    double[] daysWithRain = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {

        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            daysWithRain[i] = data[i, 0] + data[i, 1] + data[i, 2];
            double biggestRain = daysWithRain.Max();

            if (daysWithRain[i] == biggestRain)
            {
                day = $"{i + 1}. nap";
            }
        }
    }
    return day;
}

string GetDayWithSmallestAmountOfRain(double[,] data)
{
    string day = string.Empty;
    double[] daysWithRain = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            daysWithRain[i] = data[i, 0] + data[i, 1] + data[i, 2];
            double biggestRain = daysWithRain.Min();

            if (daysWithRain[i] == biggestRain)
            {
                day = $"{i + 1}. nap";
            }
        }
    }
    return day;
}

string GetDayWithLargestAmountOfMorningRain(double[,] data)
{
    string day = string.Empty;
    double[] daysWithRain = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {

        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            daysWithRain[i] = data[i, 0] + data[i, 0] + data[i, 0];
            double biggestRain = daysWithRain.Max();

            if (daysWithRain[i] == biggestRain)
            {
                day = $"{i + 1}. nap";
            }
        }
    }
    return day;
}

string GetDayWithLargestAmountOfRainFrom6To22(double[,] data)
{
    string day = string.Empty;
    double[] daysWithRain = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {

        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            daysWithRain[i] = data[i, 1] + data[i, 1] + data[i, 1];
            double biggestRain = daysWithRain.Max();

            if (daysWithRain[i] == biggestRain)
            {
                day = $"{i + 1}. nap";
            }
        }
    }
    return day;
}