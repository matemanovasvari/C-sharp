int size = 5;
int[,] matrix = FillMatrix(size);
Random rnd = new Random();

int result = SumOfDiagonal(matrix);
Console.WriteLine(result);

int[,] FillMatrix(int size)
{
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
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == j)
            {
                result += matrix[i, j];
            }
        }
        Console.WriteLine();
    }
    return result;
};

void ItemsBelowDiagonal(int[,] matrix)
{

    for (var i = 0; i < size; i++)
    {
        for (var j = 0; j < size; j++)
        {
            if (i > j)
            {
                Console.Write($"A matrix elleme: [{i},{j}] = matrix[i][j]");
            }
        }
    }
};