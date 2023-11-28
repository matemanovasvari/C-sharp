using IOLibrary;

double sizeOfPaintableSurface = ExtendedConsole.ReadDouble("Please type in the size of the paintable surface!: ");

double amountOfPaint = CalculatePaintAmount(sizeOfPaintableSurface);
double priceOfPaint = CalculatePriceOfPaint(amountOfPaint);

Console.WriteLine($"The cost of {amountOfPaint} liters of paint is: {priceOfPaint}");

double CalculatePaintAmount(double sizeOfSurface)
{
    double amountOfPaint = sizeOfSurface * 0.15;
    return amountOfPaint;
}
double CalculatePriceOfPaint(double paintAmount)
{
    double price = paintAmount * 930;
    return price;
}