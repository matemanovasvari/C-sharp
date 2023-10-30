int triangleSize;

Console.WriteLine("How big should the triangle be?");
triangleSize = int.Parse(Console.ReadLine());

for (int i = triangleSize; i >= 1; i--)
{
    Console.Write("\n");
    for (int j = i; j >= 1; j--)
    {
        Console.Write($"\t{j}");
    }
}