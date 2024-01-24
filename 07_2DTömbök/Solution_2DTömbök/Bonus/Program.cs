int size = 3;
int[,] matrix = FillMatrix(size);


PrintMatrixToConsole(matrix);
Console.WriteLine("\n\n\n");
PrintTransposeOfMatrixToConsole(matrix);

int[,] FillMatrix(int size)
{
    Random rnd = new Random();

    int[,] matrix = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
};

void PrintMatrixToConsole(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"[{i},{j}] = {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
};

void PrintTransposeOfMatrixToConsole(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"[{i},{j}] = {matrix[j, i]}\t");
        }
        Console.WriteLine();
    }
};