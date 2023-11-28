using IOLibrary;

const int BASE_TAX = 1000;

double landWidth = ExtendedConsole.ReadDouble("Please type in your land's width!: ");
double landLenght = ExtendedConsole.ReadDouble("Please type in your land's length!: ");

double tax= CalculateTax(landWidth, landLenght, BASE_TAX);

Console.WriteLine($"Your tax is: {tax}Ft");

double CalculateTax(double width, double lenght, int baseTax)
{
    double tax = (width * lenght) * baseTax;
    return landWidth < 20 && landLenght < 30 ? tax * 0.75 : tax;
}