int size = 5;
int[,] matrix = FillMatrix(size);

PrintMatrixToConsole(matrix);

Console.WriteLine("1 – Keresse ki a mátrix(n x n) dimenziójú tömb fő átlójának összegét.");
int sumOfDiagonal = SumOfDiagonal(matrix);
Console.WriteLine(sumOfDiagonal);

Console.WriteLine("\n2 – Keresse ki a mátrix (n x n) dimenziójú tömb mellékátlóinak elemét egy többmbe.");
int[] secondDiagonalItems = GetSecondDiagonal(matrix);
WriteArray(secondDiagonalItems);

Console.WriteLine("3 – Keresse ki a mátrix (n x n) dimenziójú tömb fő átló feletti elemeket. A kiíratás az alábbi minta szerint történjen:");
PrintItemsAboveDiagonalToConsole(matrix);

Console.WriteLine("4 – Keresse ki a mátrix (n x n) dimenziójú tömb fő átló alatti elemeket. A kiíratás az alábbi minta szerint történjen:");
PrintItemsBelowDiagonalToConsole(matrix);

Console.WriteLine("5 – Keresse ki a mátrix (n x n) dimenziójú tömb mellékátló alatti elemekből a legnagyobbat.");
int[] numbersBelowSecondSiagonal = GetNumbersBelowSecondDiagonal(matrix);
int maxNumber = numbersBelowSecondSiagonal.Max(x => x);
Console.WriteLine(maxNumber);

Console.WriteLine("6 – Keresse ki a mátrix (n x n) dimenziójú tömb mellékátló feletti elemekből a legkisebet.");
int[] numbersAboveSecondSiagonal = GetNumbersAboveSecondDiagonal(matrix);
int minNumber = numbersAboveSecondSiagonal.Max(x => x);
Console.WriteLine(minNumber);

int[,] FillMatrix(int size)
{ 
    Random rnd = new Random();
    
    int[,] matrix = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = rnd.Next(1, 21);
        }
    }
    return matrix;
};

int SumOfDiagonal(int[,] matrix)
{
    int result = 0;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == j)
            {
                result += matrix[i, j];
            }
        }
    }
    return result;
};

void PrintMatrixToConsole(int[,] matrix){
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"[{i},{j}] = {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
};

int[] GetSecondDiagonal(int[,] matrix)
{
    int[] secondDiagonalItems = new int[size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if(j == size - i -1)
            {
                secondDiagonalItems[i] = matrix[i, j];
            }
        }
    }

    return secondDiagonalItems;
};

void WriteArray(int[] array)
{
    foreach(int i in array)
    {
        Console.WriteLine(i);
    }
}

void PrintItemsAboveDiagonalToConsole(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j > i)
            {
                Console.Write($"[{i},{j}]\t");
            }
            else
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
};

void PrintItemsBelowDiagonalToConsole(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j < i)
            {
                Console.Write($"[{i},{j}]\t");
            }
        }
        Console.WriteLine();
    }
};

int[] GetNumbersBelowSecondDiagonal(int[,] matrix)
{
    int[] itemsBelowSecondDiagonal = new int[10];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j > size - i - 1)
            {
                itemsBelowSecondDiagonal[i] = matrix[i, j];
            }
        }
    }

    return itemsBelowSecondDiagonal;
};

int[] GetNumbersAboveSecondDiagonal(int[,] matrix)
{
    int[] itemsBelowSecondDiagonal = new int[10];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (j > size - i - 1)
            {
                itemsBelowSecondDiagonal[i] = matrix[i, j];
            }
        }
    }

    return itemsBelowSecondDiagonal;
};