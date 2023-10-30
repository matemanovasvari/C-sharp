int triangleSize;

Console.WriteLine("How big should the triangle be?");
triangleSize = int.Parse(Console.ReadLine());

for(int i = 1; i <= triangleSize; i++)
{
    Console.Write("\n");
    for(int j = 1; j <= i; j++)
    {
        Console.Write($"\t{j}");
    }
}