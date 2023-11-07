int pyramidSize;

Console.WriteLine("How big should the pyramid be?");
pyramidSize = int.Parse(Console.ReadLine());

for (int i = -1; i < pyramidSize*2; i+=2)
{
    for(int j = i/2; j < pyramidSize-1; j++)
    {
        Console.Write("\t");
    }
    for (int k = 1; k <= i; k++)
    {

        Console.Write($"{k} \t");
    }
    Console.WriteLine();
}