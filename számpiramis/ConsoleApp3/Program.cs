int pyramidSize;

Console.WriteLine("How big should the pyramid be?");
pyramidSize = int.Parse(Console.ReadLine());

for (int i = -1; i < pyramidSize; i++)
{
    for(int j = -1; j < pyramidSize+i; j++)
    {
        if (j < pyramidSize - i - 1)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{j}");
        }
    }
    Console.Write("\n");
}