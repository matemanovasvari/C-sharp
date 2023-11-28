using IOLibrary;

double testPoints = ExtendedConsole.ReadDouble("Please type in a number of points!: ");
int grade = CalculateGrade(testPoints);

Console.WriteLine($"Your grade is: {grade}");

int CalculateGrade(double points)
{
    return points switch
    {
        < 50 => 1,
        < 60 => 2,
        < 70 => 3,
        < 85 => 4,
        >= 85 => 5
    };
}