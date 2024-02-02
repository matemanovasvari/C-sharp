using Custom.Library.ConsoleExtension;

const int NUMBER_OF_ROWS = 7;
const int NUMBER_OF_COLUMNS = 3;
Random rnd = new Random();

double[,] dataOfWeathers = GetMatrix();

PrintMatrixToConsole(dataOfWeathers);

double[] dailyWeatherAverageInAscendingOrder = DailyWeatherAverage(dataOfWeathers);
Array.Sort(dailyWeatherAverageInAscendingOrder);
WriteArray(dailyWeatherAverageInAscendingOrder);

string dayWithLargestRain = GetDayWithLargestAmountOfRain(dataOfWeathers);
Console.WriteLine();
Console.WriteLine(dayWithLargestRain);

string dayWithSmallestRain = GetDayWithSmallestAmountOfRain(dataOfWeathers);
Console.WriteLine();
Console.WriteLine(dayWithSmallestRain);

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

string GetDayWithLargestAmountOfRain(double[,] data)
{
    string day = "";
    double ifstatement = 0;

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        if (data[i, 0] + data[i, 1] + data[i, 2] > ifstatement)
        {
            ifstatement = data[i, 0] + data[i, 1] + data[i, 2];
            day = $"{i + 1}. nap";
        }
    }
    return day;
}

string GetDayWithSmallestAmountOfRain(double[,] data)
{
    string day = "";
    double ifstatement = data[0, 0] + data[0, 1] + data[0, 2];

    for (int i = 0; i < NUMBER_OF_ROWS; i++)
    {
        if (data[i, 0] + data[i, 1] + data[i, 2] < ifstatement)
        {
            ifstatement = data[i, 0] + data[i, 1] + data[i, 2];
            day = $"{i + 1}. nap";
        }
    }
    return day;
}