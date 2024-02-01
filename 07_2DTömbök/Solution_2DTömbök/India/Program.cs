using Custom.Library.ConsoleExtension;

const int NUMBER_OF_ROWS = 7;
const int NUMBER_OF_COLUMNS = 3;
Random rnd = new Random();

double[,] dataOfWeathers = GetMatrix();

PrintMatrixToConsole(dataOfWeathers);

double[] dailyWeatherAverageInAscendingOrder = DailyWeatherAverage(dataOfWeathers);
Array.Sort(dailyWeatherAverageInAscendingOrder);
WriteArray(dailyWeatherAverageInAscendingOrder);


double[] sumsOfDailyWeather = DailyWeatherSum(dataOfWeathers);

double maxRain = sumsOfDailyWeather.Max();
double[] dayWithMaxRain = sumsOfDailyWeather.Where(x => x == maxRain).ToArray();
Console.WriteLine();
WriteDay(dayWithMaxRain);

double minRain = sumsOfDailyWeather.Min();
double[] dayWithMinRain = sumsOfDailyWeather.Where(x => x == minRain).ToArray();
Console.WriteLine();
WriteDay(dayWithMinRain);



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

void WriteDay(double[] array)
{
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.WriteLine($"{i + 1}.nap");
    }
}
double[] DailyWeatherSum(double[,] matrix)
{
    double[] dailyWeatherSums = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            dailyWeatherSums[i] = matrix[i, 0] + matrix[i, 1] + matrix[i, 2];
        }


    }

    return dailyWeatherSums;
}

double[] GetMorningRain(double[,] matrix)
{
    double[] morningRain = new double[7];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        for (int j = 0; j < NUMBER_OF_COLUMNS; j++)
        {
            morningRain[i] = matrix[i, 0];
        }


    }

    return morningRain;
}