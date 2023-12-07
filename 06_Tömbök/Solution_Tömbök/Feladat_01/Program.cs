Random rnd = new Random();

int[] array = await GetIntArrayAsync(10);

Console.WriteLine("Generated array:");
ReversePrintArrayToConsole(array);

int sum = GetArraySum(array);
Console.WriteLine($"\nSum of the array: {sum}");

double average = (double)sum / array.Length;
Console.WriteLine($"\nAverage of the arry: {average:F2}");

Console.WriteLine("\nEven elements of the array:");
int[] evenNumbersArray = GetEvenNumbersFromArray(array);
PrintArrayToConsole(evenNumbersArray);

int numberOfTwoDigitNumbers = GetTwoDigitsNumbers(array);
Console.WriteLine($"\nNumber of numbers greater then 9 in the array: {numberOfTwoDigitNumbers}");

Console.WriteLine($"\nSingle digit elements of the array: ");
int[] singleElementsOfTheArray = array.Where(x => x < 10).ToArray();
PrintArrayToConsole(singleElementsOfTheArray);

int oddNumbersSum = CalculateOddNumbersSumOfArray(array); //array.Where(x => x % 2 != 0).Sum(x => x);
Console.WriteLine($"\nSum of odd numbers in the array: {oddNumbersSum}");

int zeroEndedNumbers = array.Count(x => x % 10 == 0);
Console.WriteLine($"\nNumbers of numbers that end with zero: {zeroEndedNumbers}");

Console.WriteLine($"\nArray in ascending order:");
OrderArrayAscending(array);
PrintArrayToConsole(array);

async Task<int[]> GetIntArrayAsync(int arraySize)
{
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rnd.Next(0, 100);
        await Task.Delay(100);
    }

    return array;
}

void PrintArrayToConsole(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.WriteLine($"[{i + 1}] = {arrayToPrint[i]}");
    }
}

int GetArraySum(int[] array)
{
    int sum = 0;

    foreach (int item in array)
    {
        sum += item;
    }

    return sum;
}

int[] GetEvenNumbersFromArray(int[] array)
{
    int[] evenNumbers = array.Where(x => x % 2 == 0).ToArray();

    return evenNumbers;
}

int GetTwoDigitsNumbers(int[] array)
{
    int counter = 0;

    foreach(int number in array)
    {
        if(number > 9)
        {
            counter++;
        }
    }

    return counter;
}

int CalculateOddNumbersSumOfArray(int[] array)
{
    int sum = 0;

    foreach(int number in array)
    {
        if(number % 2 != 0)
        {
            sum += number;
        }
    }

    return sum;
}

void OrderArrayAscending(int[] array)
{
    int temp = 0;

    for(int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void ReversePrintArrayToConsole(int[] arrayToPrint)
{
    for (int i = arrayToPrint.Length - 1; i >= 0; i--)
    {
        Console.WriteLine($"[{i + 1}] = {arrayToPrint[i]}");
    }
}