Shape shape = new Square(10);

shape = new Rectangle(10, 20);
PrintShape(shape);

//nem lehet, mivel a Circle osztály nem valósítja meg az IShape interface-t
//IShape circle = new Circle(10);

void PrintShape(IShape shape)
{
    if(shape is Square)
    {
        Console.WriteLine("square");
        Console.WriteLine(shape);
    }
    else if(shape is Rectangle)
    {
        Console.WriteLine("****" +
                          "\n*\t*\n*\t*" +
                          "\n****");
        Console.WriteLine(shape);
    }
    else
    {
        Console.WriteLine("ismeretlen alakzat");
    }
}